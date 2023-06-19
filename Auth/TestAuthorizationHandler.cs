using HotChocolate.Resolvers;
using Microsoft.AspNetCore.Authorization;

namespace HotChocolate_13_1_Authhandler.Auth
{
    public class TestAuthorizationHandler : AuthorizationHandler<TestAuthorizationRequirement, IResolverContext>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, TestAuthorizationRequirement requirement, IResolverContext resource)
        {
            Console.WriteLine("AuthHandler called.");
            context.Succeed(requirement);
            return Task.CompletedTask;
        }
    }

    public class TestAuthorizationRequirement : IAuthorizationRequirement
    {
        /// <summary>
        /// Initialize the requirement.
        /// </summary>
        /// <param name="level">The level that is needed.</param>
        public TestAuthorizationRequirement()
        {
        }
    }
}