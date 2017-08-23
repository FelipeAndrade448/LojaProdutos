﻿using LojaProduto.Services.Spec.Services;
using SQFramework.Core.Reflection;

namespace LojaProduto.Services.Impl.Services
{
    public class ServiceBase : IServiceBase
    {
        public string GetServiceVersion()
        {
            return AssemblyHelper.GetAssemblyVersion(GetType());
        }
    }
}