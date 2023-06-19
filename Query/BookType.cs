using HotChocolate_13_1_Authhandler.Types;

namespace HotChocolate_13_1_Authhandler.Query
{
    public class BookType : ObjectType<Book>
    {
        protected override void Configure(IObjectTypeDescriptor<Book> descriptor)
        {
            base.Configure(descriptor);

            descriptor.Field(x => x.Title);

            descriptor.Field(x => x.Author);

            descriptor.Field(x => x.Publisher);
        }
    }
}
