using HotChocolate_13_1_Authhandler.Types;

namespace HotChocolate_13_1_Authhandler.Query
{
    public class AuthorTypeWithApplyBeforeResolver : ObjectType<Author>
    {
        protected override void Configure(IObjectTypeDescriptor<Author> descriptor)
        {
            base.Configure(descriptor);

            descriptor.Field(x => x.Name)
                .Authorize("TestPolicy", apply: HotChocolate.Authorization.ApplyPolicy.BeforeResolver);
        }
    }
}
