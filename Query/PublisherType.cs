using HotChocolate_13_1_Authhandler.Types;

namespace HotChocolate_13_1_Authhandler.Query
{
    public class PublisherType : ObjectType<Publisher>
    {
        protected override void Configure(IObjectTypeDescriptor<Publisher> descriptor)
        {
            base.Configure(descriptor);

            descriptor.Field(x => x.Name)
                .Authorize("TestPolicy");
        }
    }
}