namespace Lyf.ExcelKit.Editor
{
    // 用于被修改的代码文件
    public partial class OpenWindow
    {
        public void GenerateScriptableData()
        {
            var generateMethod = typeof(ScriptableDataGenerate).GetMethod("GenerateScriptableObject")?.MakeGenericMethod(typeof(void), typeof(void));
            generateMethod?.Invoke(null, new object[] { _filePath, _assetPath });
        }
    }
}