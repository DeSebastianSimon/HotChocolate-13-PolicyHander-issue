using HotChocolate_13_1_Authhandler.Types;

namespace HotChocolate_13_1_Authhandler.Query
{
    public class AuthorType : ObjectType<Author>
    {
        protected override void Configure(IObjectTypeDescriptor<Author> descriptor)
        {
            base.Configure(descriptor);

            descriptor.Field(x => x.Name)
                .Authorize("TestPolicy");
        }
    }
}
