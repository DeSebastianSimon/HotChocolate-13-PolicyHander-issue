using HotChocolate_13_1_Authhandler.Types;

namespace HotChocolate_13_1_Authhandler.Query
{
    public class QueryType : ObjectType<Query>
    {
        protected override void Configure(IObjectTypeDescriptor<Query> descriptor)
        {
            base.Configure(descriptor);

            descriptor.Field("book")
                //.Authorize("TestPolicy")
                .Resolve<Book>(context =>
                {
                    return new Book();
                });
        }
    }
}
