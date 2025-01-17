﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System.Composition;
using Microsoft.CodeAnalysis.CodeRefactorings;
using Microsoft.CodeAnalysis.Diagnostics;

namespace Microsoft.CodeAnalysis.ExternalAccess.LiveShare.CodeActions
{
    [Shared]
    [ExportCodeRefactoringProvider(StringConstants.CSharpLspLanguageName)]
    internal class CSharpLspCodeActionProvider : RoslynCodeActionProvider
    {
        [ImportingConstructor]
        public CSharpLspCodeActionProvider(RoslynLspClientServiceFactory roslynLspClientServiceFactory, IDiagnosticAnalyzerService diagnosticAnalyzerService)
            : base(roslynLspClientServiceFactory, diagnosticAnalyzerService)
        {
        }
    }

    [Shared]
    [ExportCodeRefactoringProvider(StringConstants.VBLspLanguageName)]
    internal class VBLspCodeActionProvider : RoslynCodeActionProvider
    {
        [ImportingConstructor]
        public VBLspCodeActionProvider(RoslynLspClientServiceFactory roslynLspClientServiceFactory, IDiagnosticAnalyzerService diagnosticAnalyzerService)
            : base(roslynLspClientServiceFactory, diagnosticAnalyzerService)
        {
        }
    }
}
