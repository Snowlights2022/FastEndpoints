using JetBrains.Annotations;

namespace FastEndpoints;

/// <summary>
/// use this attribute to specify a DELETE route for an endpoint
/// </summary>
[AttributeUsage(AttributeTargets.Class, Inherited = false)]
public sealed class HttpDeleteAttribute : HttpAttribute
{
    /// <summary>
    /// use this attribute to specify a DELETE route for an endpoint
    /// </summary>
    /// <param name="routes">the routes for the endpoint</param>
    public HttpDeleteAttribute([RouteTemplate] params string[] routes) : base(Http.DELETE, routes) { }
}