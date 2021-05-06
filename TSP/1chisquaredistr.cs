/*************************************************************************
Cephes Math Library Release 2.8:  June, 2000
Copyright 1984, 1987, 2000 by Stephen L. Moshier

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

class chisquaredistr
{
    /*************************************************************************
    Площадь под левым "хвостом" графика функции плотности вероятности
    распределения хи-квадрат с v степенями свободы

    Cephes Math Library Release 2.8:  June, 2000
    Copyright 1984, 1987, 2000 by Stephen L. Moshier
    *************************************************************************/
    public static double chisquaredistribution(double v,
        double x)
    {
        double result = 0;

        System.Diagnostics.Debug.Assert(x>=0 & v>=1, "Domain error in ChiSquareDistribution");
        result = igammaf.incompletegamma(v/2.0, x/2.0);
        return result;
    }


    /*************************************************************************
    Площадь под правым "хвостом" графика функции плотности вероятности
    распределения хи-квадрат с v степенями свободы

    Cephes Math Library Release 2.8:  June, 2000
    Copyright 1984, 1987, 2000 by Stephen L. Moshier
    *************************************************************************/
    public static double chisquarecdistribution(double v,
        double x)
    {
        double result = 0;

        System.Diagnostics.Debug.Assert(x>=0 & v>=1, "Domain error in ChiSquareDistributionC");
        result = igammaf.incompletegammac(v/2.0, x/2.0);
        return result;
    }


    /*************************************************************************
    Находит такое x, что площадь под правым "хвостом" графика функции плотности
    вероятности распределения хи-квадрат с v степенями свободы равна y.

    Cephes Math Library Release 2.8:  June, 2000
    Copyright 1984, 1987, 2000 by Stephen L. Moshier
    *************************************************************************/
    public static double invchisquaredistribution(double v,
        double y)
    {
        double result = 0;

        System.Diagnostics.Debug.Assert(y>=0 & y<=1 & v>=1, "Domain error in InvChiSquareDistribution");
        result = 2*igammaf.invincompletegammac(0.5*v, y);
        return result;
    }
}
