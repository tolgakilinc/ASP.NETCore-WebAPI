using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<BolumManager>().As<IBolumService>().SingleInstance();
            // services.AddSingleton<IProductService,ProductManager>(); -> karşılığı yukarıdaki gibi
            builder.RegisterType<EfBolumDal>().As<IBolumDal>().SingleInstance();

            builder.RegisterType<KullaniciManager>().As<IKullaniciService>().SingleInstance();
            builder.RegisterType<EfKullaniciDal>().As<IKullaniciDal>().SingleInstance();

            builder.RegisterType<DersManager>().As<IDersService>().SingleInstance();
            builder.RegisterType<EfDersDal>().As<IDersDal>().SingleInstance();

            builder.RegisterType<DiplomaManager>().As<IDiplomaService>().SingleInstance();
            builder.RegisterType<EfDiplomaDal>().As<IDiplomaDal>().SingleInstance();

            builder.RegisterType<LiseManager>().As<ILiseService>().SingleInstance();
            builder.RegisterType<EfLiseDal>().As<ILiseDal>().SingleInstance();

            builder.RegisterType<AlanManager>().As<IAlanService>().SingleInstance();
            builder.RegisterType<EfAlanDal>().As<IAlanDal>().SingleInstance();

            builder.RegisterType<NetManager>().As<INetService>().SingleInstance();
            builder.RegisterType<EfNetDal>().As<INetDal>().SingleInstance();


            builder.RegisterType<SoruManager>().As<ISoruService>().SingleInstance();
            builder.RegisterType<EfSoruDal>().As<ISoruDal>().SingleInstance();

            builder.RegisterType<SoruHavuzManager>().As<ISoruHavuzService>().SingleInstance();
            builder.RegisterType<EfSoruHavuzDal>().As<ISoruHavuzDal>().SingleInstance();

            builder.RegisterType<UniversiteManager>().As<IUniversiteService>().SingleInstance();
            builder.RegisterType<EfUniversiteDal>().As<IUniversiteDal>().SingleInstance();

            builder.RegisterType<VeliTakipManager>().As<IVeliTakipService>().SingleInstance();
            builder.RegisterType<EfVeliTakipDal>().As<IVeliTakipDal>().SingleInstance();

            builder.RegisterType<GunManager>().As<IGunService>().SingleInstance();
            builder.RegisterType<EfGunDal>().As<IGunDal>().SingleInstance();

            builder.RegisterType<ProgramManager>().As<IProgramService>().SingleInstance();
            builder.RegisterType<EfProgramDal>().As<IProgramDal>().SingleInstance();

            builder.RegisterType<SehirManager>().As<ISehirService>().SingleInstance();
            builder.RegisterType<EfSehirDal>().As<ISehirDal>().SingleInstance();

            builder.RegisterType<SoruTipManager>().As<ISoruTipService>().SingleInstance();
            builder.RegisterType<EfSoruTipDal>().As<ISoruTipDal>().SingleInstance();

            builder.RegisterType<UnvanManager>().As<IUnvanService>().SingleInstance();
            builder.RegisterType<EfUnvanDal>().As<IUnvanDal>().SingleInstance();

            builder.RegisterType<VeliManager>().As<IVeliService>().SingleInstance();
            builder.RegisterType<EfVeliDal>().As<IVeliDal>().SingleInstance();

            builder.RegisterType<SoruYanitManager>().As<ISoruYanitService>().SingleInstance();
            builder.RegisterType<EfSoruYanitDal>().As<ISoruYanitDal>().SingleInstance();


            builder.RegisterType<DenemeManager>().As<IDenemeService>().SingleInstance();
            builder.RegisterType<EfDenemeDal>().As<IDenemeDal>().SingleInstance();

            builder.RegisterType<SınıfManager>().As<ISınıfService>().SingleInstance();
            builder.RegisterType<EfSınıfDal>().As<ISınıfDal>().SingleInstance();

            builder.RegisterType<DersKategoriManager>().As<IDersKategoriService>().SingleInstance();
            builder.RegisterType<EfDersKategoriDal>().As<IDersKategoriDal>().SingleInstance();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
