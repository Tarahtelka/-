/*************************************************************************
Cephes Math Library Release 2.8:  June, 2000
Copyright 1984, 1987, 1995, 2000 by Stephen L. Moshier

Contributors:
    * Sergey Bochkanov (ALGLIB project). Translation from C to
      pseudocode.

See subroutines comments for additional copyrights.

Redistribution and use in source and binary forms, with or without
modification, are permitted provided that the following conditions are
met:

- Redistributions of source code must retain the above copyright
  notice, this list of conditions and the following disclaimer.

- Redistributions in binary form must reproduce the above copyright
  notice, this list of conditions and the following disclaimer listed
  in this license in the documentation and/or other materials
  provided with the distribution.

- Neither the name of the copyright holders nor the names of its
  contributors may be used to endorse or promote products derived from
  this software without specific prior written permission.

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS
"AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT
LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR
A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT
OWNER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL,
SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT
LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE,
DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY
THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
(INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE
OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
*************************************************************************/

using System;

class fdistr
{
    /*************************************************************************
    Интегральная функция вероятности F-распределения со степенями свободы a и b

    Входные параметры:
        a,b -   степени свободы
        x   -   аргумент
        
    Результат: P(F<=x|a,b)

    Cephes Math Library Release 2.8:  June, 2000
    Copyright 1984, 1987, 1995, 2000 by Stephen L. Moshier
    *************************************************************************/
    public static double fdistribution(int a,
        int b,
        double x)
    {
        double result = 0;
        double w = 0;

        System.Diagnostics.Debug.Assert(a>=1 & b>=1 & x>=0, "Domain error in FDistribution");
        w = a*x;
        w = w/(b+w);
        result = ibetaf.incompletebeta(0.5*a, 0.5*b, w);
        return result;
    }


    /*************************************************************************
    Дополнение интегральной функции вероятности F-распределения
    со степенями свободы a и b до единицы

    Входные параметры:
        a,b -   степени свободы
        x   -   аргумент

    Результат: 1-P(F<=x|a,b)

    Cephes Math Library Release 2.8:  June, 2000
    Copyright 1984, 1987, 1995, 2000 by Stephen L. Moshier
    *************************************************************************/
    public static double fcdistribution(int a,
        int b,
        double x)
    {
        double result = 0;
        double w = 0;

        System.Diagnostics.Debug.Assert(a>=1 & b>=1 & x>=0, "Domain error in FCDistribution");
        w = b/(b+a*x);
        result = ibetaf.incompletebeta(0.5*b, 0.5*a, w);
        return result;
    }


    /*************************************************************************
    Функция, обратная к интегральной функции вероятности F-распределения
    со степенями свободы a и b

    Алгоритм находит такое x, что P(F<=x|a,b)=y

    Входные параметры:
        a,b -   степени свободы
        y   -   аргумент

    Cephes Math Library Release 2.8:  June, 2000
    Copyright 1984, 1987, 1995, 2000 by Stephen L. Moshier
    *************************************************************************/
    public static double invfdistribution(int a,
        int b,
        double y)
    {
        double result = 0;
        double w = 0;

        System.Diagnostics.Debug.Assert(a>=1 & b>=1 & y>0 & y<=1, "Domain error in InvFDistribution");
        
        //
        // Compute probability for x = 0.5
        //
        w = ibetaf.incompletebeta(0.5*b, 0.5*a, 0.5);
        
        //
        // If that is greater than y, then the solution w < .5
        // Otherwise, solve at 1-y to remove cancellation in (b - b*w)
        //
        if( w>y | y<0.001 )
        {
            w = ibetaf.invincompletebeta(0.5*b, 0.5*a, y);
            result = (b-b*w)/(a*w);
        }
        else
        {
            w = ibetaf.invincompletebeta(0.5*a, 0.5*b, 1.0-y);
            result = b*w/(a*(1.0-w));
        }
        return result;
    }
}
