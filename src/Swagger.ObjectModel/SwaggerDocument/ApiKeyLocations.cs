﻿namespace Swagger.ObjectModel.SwaggerDocument
{
    using global::Swagger.ObjectModel.Attributes;

    /// <summary>
    /// The api key locations.
    /// </summary>
    [SwaggerData]
    public enum ApiKeyLocations
    {
        /// <summary>
        /// The query.
        /// </summary>
        [SwaggerEnumValue("query")]
        Query,

        /// <summary>
        /// The header.
        /// </summary>
        [SwaggerEnumValue("header")]
        Header
    }
}