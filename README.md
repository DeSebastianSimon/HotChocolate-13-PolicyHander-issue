#### Repo to reproduce a Problem in HotChocolate calls to policy handlers introduced in HC 13


Steps to reproduce:

1. Run Project as is. 
1. Query the instance  query below.
1. Query will result in 'AUTH_NOT_AUTHORIZED' response, no printout to console
1. Stop the instance.
1. Replace Program.cs line 24 with line 25
1. Start insance and query again
1. Query will return results and Console will have printed 'AuthHandler called.'
2. 
```
query {
  book {
    title
    author {
      name
    }
  }
}
```

ok result:
```
{
  "data": {
    "book": {
      "title": "Book Title",
      "author": {
        "name": "Author Name"
      }
    }
  }
}
```

not ok result:
```
{
  "errors": [
    {
      "message": "The current user is not authorized to access this resource.",
      "extensions": {
        "code": "AUTH_NOT_AUTHORIZED"
      }
    }
  ]
}
```
