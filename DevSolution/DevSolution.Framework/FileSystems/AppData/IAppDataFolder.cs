using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevSolution.Caching;

namespace DevSolution.FileSystems.AppData
{
    /// <summary>
    /// Abstraction of App_Data folder. All virtual paths passed in or returned are relative to "~/App_Data".
    /// Expected to work on physical filesystem, but decouples core system from web hosting apis
    /// </summary>
    public interface IAppDataFolder : IVolatileProvider
    {
        /// <summary>
        /// 列出指定路径下的所有文件名称
        /// </summary>
        /// <param name="path">指定路径</param>
        /// <returns></returns>
        IEnumerable<string> ListFiles(string path);

        /// <summary>
        /// 列出指定路径下的所有目录
        /// </summary>
        /// <param name="path">指定路径</param>
        /// <returns></returns>
        IEnumerable<string> ListDirectories(string path);

        /// <summary>
        /// 拼接路径
        /// </summary>
        /// <param name="paths">待拼接路径</param>
        /// <returns></returns>
        string Combine(params string[] paths);

        /// <summary>
        /// 文件是否存在
        /// </summary>
        /// <param name="path">文件路径</param>
        /// <returns></returns>
        bool FileExists(string path);

        /// <summary>
        /// 创建或覆盖指定路径下的文件。
        /// </summary>
        /// <param name="path">创建文件的路径和名称。</param>
        /// <param name="content">写入创建文件中的内容。</param>
        /// <remarks>If the folder doesn't exist, it will be created.</remarks>
        void CreateFile(string path, string content);

        /// <summary>
        /// 创建或覆盖指定路径下的文件。
        /// </summary>
        /// <param name="path">创建文件的路径和名称。</param>
        /// <returns>
        /// 指定路径文件可供读/写的<see cref="Stream"/>对象。
        /// </returns>
        /// <remarks>如果文件夹不存在，它将被创建。</remarks>
        Stream CreateFile(string path);

        /// <summary>
        /// 打开一个文本文件,读取文件的所有行,然后关闭该文件。
        /// </summary>
        /// <param name="path">文件的路径和名称。</param>
        /// <returns>一个字符串包含文件的所有行，如果文件不存在返回 <code>null</code> 。</returns>
        string ReadFile(string path);

        /// <summary>
        /// 打开一个已存在的文件进行读取。
        /// </summary>
        /// <param name="path">文件的路径和名称。</param>
        /// <returns>
        /// 指定路径文件可供只读的<see cref="Stream"/>对象。
        /// </returns>
        Stream OpenFile(string path);

        void StoreFile(string sourceFileName, string destinationPath);

        void DeleteFile(string path);

        DateTime GetFileLastWriteTimeUtc(string path);

        void CreateDirectory(string path);

        bool DirectoryExists(string path);

        IVolatileToken WhenPathChanges(string path);

        string MapPath(string path);

        string GetVirtualPath(string path);
    }
}