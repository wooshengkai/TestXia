﻿using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TestXia.EntityFrameworkCore;
using TestXia.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace TestXia.Web.Tests
{
    [DependsOn(
        typeof(TestXiaWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class TestXiaWebTestModule : AbpModule
    {
        public TestXiaWebTestModule(TestXiaEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TestXiaWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(TestXiaWebMvcModule).Assembly);
        }
    }
}