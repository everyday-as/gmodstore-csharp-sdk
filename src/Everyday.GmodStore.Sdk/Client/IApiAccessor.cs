/*
 * GmodStore
 *
 * Welcome to the GmodStore API! You can use our API to access Gmodstore API endpoints, which can be used interact with Gmodstore programmatically.
 *
 * The version of the OpenAPI document: 1.0.1
 *
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;

namespace Everyday.GmodStore.Sdk.Client
{
/// <summary>
/// Represents configuration aspects required to interact with the API endpoints.
/// </summary>
public interface IApiAccessor
{
/// <summary>
/// Gets or sets the configuration object
/// </summary>
/// <value>An instance of the Configuration</value>
IReadableConfiguration Configuration {
	get; set;
}

/// <summary>
/// Gets the base path of the API client.
/// </summary>
/// <value>The base path</value>
String GetBasePath();

/// <summary>
/// Provides a factory method hook for the creation of exceptions.
/// </summary>
ExceptionFactory ExceptionFactory {
	get; set;
}
}
}
