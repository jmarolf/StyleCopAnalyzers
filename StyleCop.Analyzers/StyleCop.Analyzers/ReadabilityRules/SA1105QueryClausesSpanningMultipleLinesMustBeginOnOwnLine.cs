﻿namespace StyleCop.Analyzers.ReadabilityRules
{
    using System.Collections.Immutable;
    using Microsoft.CodeAnalysis;
    using Microsoft.CodeAnalysis.Diagnostics;

    /// <summary>
    /// A clause within a C# query expression spans across multiple lines, and does not begin on its own line.
    /// </summary>
    /// <remarks>
    /// <para>A violation of this rule occurs when a query clause spans across multiple lines, but does not begin on its
    /// own line. For example:</para>
    /// <code language="csharp">
    /// object x = 
    ///     select a in b from c.GetCustomers(
    ///         2, "x");
    /// </code>
    /// <para>The query clause can correctly be written as:</para>
    /// <code language="csharp">
    /// object x =
    ///     select a
    ///     in b
    ///     from c.GetCustomers(
    ///         2, "x");
    /// </code>
    /// </remarks>
    [DiagnosticAnalyzer(LanguageNames.CSharp)]
    public class SA1105QueryClausesSpanningMultipleLinesMustBeginOnOwnLine : DiagnosticAnalyzer
    {
        /// <summary>
        /// The ID for diagnostics produced by the
        /// <see cref="SA1105QueryClausesSpanningMultipleLinesMustBeginOnOwnLine"/> analyzer.
        /// </summary>
        public const string DiagnosticId = "SA1105";
        private const string Title = "Query clauses spanning multiple lines must begin on own line";
        private const string MessageFormat = "TODO: Message format";
        private const string Category = "StyleCop.CSharp.ReadabilityRules";
        private const string Description = "A clause within a C# query expression spans across multiple lines, and does not begin on its own line.";
        private const string HelpLink = "http://www.stylecop.com/docs/SA1105.html";

        private static readonly DiagnosticDescriptor Descriptor =
            new DiagnosticDescriptor(DiagnosticId, Title, MessageFormat, Category, DiagnosticSeverity.Warning, AnalyzerConstants.DisabledNoTests, Description, HelpLink);

        private static readonly ImmutableArray<DiagnosticDescriptor> SupportedDiagnosticsValue =
            ImmutableArray.Create(Descriptor);

        /// <inheritdoc/>
        public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
        {
            get
            {
                return SupportedDiagnosticsValue;
            }
        }

        /// <inheritdoc/>
        public override void Initialize(AnalysisContext context)
        {
            // TODO: Implement analysis
        }
    }
}
