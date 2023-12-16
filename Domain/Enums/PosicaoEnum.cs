using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToDB.Mapping;

namespace Domain.Enums
{
    public enum PosicaoEnum
    {
        [MapValue("Goleiro")]
        Goleiro,
        [MapValue("Lateral direito")]
        LateralDireito,
        [MapValue("Zagueiro")]
        Zagueiro,
        [MapValue("Lateral esquerdo")]
        LateralEsquerdo,
        [MapValue("Volante")]
        Volante,
        [MapValue("Meio campista")]
        MeioCampista,
        [MapValue("Meia direita")]
        MeiaDireita,
        [MapValue("Meia esquerda")]
        MeiaEsquerda,
        [MapValue("Meia atacante")]
        MeiaAtacante,
        [MapValue("Segundo atacante")]
        SegundoAtacante,
        [MapValue("Ponta direita")]
        PontaDireita,
        [MapValue("Ponta esquerda")]
        PontaEsquerda,
        [MapValue("Centroavante")]
        Centroavente
    }
}
