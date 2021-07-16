using PMWORK.Repository;
using StructureMap;
using StructureMap.Graph;

namespace PMWORK
{
    public class TypeRegistery : Registry
    {
        public TypeRegistery()
        {
            var _db = new AppDbContext();
            For<IRequestRepairRepository>().Use<RequestRepairRepository>().Ctor<AppDbContext>().Is(_db);
            For<ICodingRepository>().Use<CodingRepository>().Ctor<AppDbContext>().Is(_db);
        }


    }


}