namespace System.CodeDom.Compiler;

/// <summary>Defines an interface for invoking compilation of source code or a CodeDOM tree using a specific compiler.</summary>
/// <summary>Defines an interface for invoking compilation of source code or a CodeDOM tree using a specific compiler.</summary>
public interface ICodeCompiler
{
	CompilerResults CompileAssemblyFromDom(CompilerParameters options, CodeCompileUnit compilationUnit);

	CompilerResults CompileAssemblyFromFile(CompilerParameters options, string fileName);

	CompilerResults CompileAssemblyFromSource(CompilerParameters options, string source);

	CompilerResults CompileAssemblyFromDomBatch(CompilerParameters options, CodeCompileUnit[] compilationUnits);

	CompilerResults CompileAssemblyFromFileBatch(CompilerParameters options, string[] fileNames);

	CompilerResults CompileAssemblyFromSourceBatch(CompilerParameters options, string[] sources);
}
