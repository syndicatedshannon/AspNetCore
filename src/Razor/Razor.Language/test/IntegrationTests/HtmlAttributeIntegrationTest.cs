﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Xunit;

namespace Microsoft.AspNetCore.Razor.Language.IntegrationTests
{
    public class HtmlAttributeIntegrationTest : IntegrationTestBase
    {
        [Fact(Skip="https://github.com/aspnet/AspNetCore/issues/6549")]
        public void HtmlWithDataDashAttribute()
        {
            // Arrange
            var projectEngine = CreateProjectEngine();
            var projectItem = CreateProjectItem();

            // Act
            var codeDocument = projectEngine.Process(projectItem);

            // Assert
            AssertDocumentNodeMatchesBaseline(codeDocument.GetDocumentIntermediateNode());
        }

        [Fact(Skip="https://github.com/aspnet/AspNetCore/issues/6549")]
        public void HtmlWithConditionalAttribute()
        {
            // Arrange
            var projectEngine = CreateProjectEngine();
            var projectItem = CreateProjectItem();

            // Act
            var codeDocument = projectEngine.Process(projectItem);

            // Assert
            AssertDocumentNodeMatchesBaseline(codeDocument.GetDocumentIntermediateNode());
        }
    }
}
