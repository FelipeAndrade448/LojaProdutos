﻿using System.ComponentModel;
using SQFramework.Core.Enums;

namespace LojaProduto.Common
{
    [TypeConverter(typeof(EnumConverter<EnumExample>))]
    public enum EnumExample
    {
        [StringValue("0", "Undefined", false)]
        Undefined = 0,
        [StringValue("1", "Example 1")]
        Example1 = 1,
        [StringValue("2", "Example 2")]
        Example2 = 2
    }
    public enum EnumStatusPedido
    {
        Aberto    = 1,
        Faturar   = 2,
        Faturado  = 3,
        Cancelado = 4
    }
    public enum EnumTipoDeVenda
    {
        Avista = 1,
        Parcelado = 2,
        Invalido = 3
    }
}