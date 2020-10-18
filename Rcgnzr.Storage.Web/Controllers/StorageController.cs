using System;
using Microsoft.AspNetCore.Mvc;

namespace Rcgnzr.Storage.Web.Controllers
{
    [Route("api/[controller]")]
    public class StorageController
    {
        /// <summary>
        ///     Получает все контейнеры.
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public IActionResult GetAll() => throw new NotImplementedException();

        /// <summary>
        ///     Получает все файлы в конкретном контейнере.
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult GetFiles(string id) => throw new NotImplementedException();
        
        /// <summary>
        ///     Получает содержимое конкретного файла
        /// </summary>
        /// <returns></returns>
        [HttpGet("{containerId}/{fileId}")]
        public IActionResult GetFile(string containerId, string fileId) => throw new NotImplementedException();
        
        /// <summary>
        ///    Создаёт контейнер.
        /// </summary>
        /// <returns></returns>
        [HttpPost("{id}")]
        public IActionResult CreateContainer(string id) => throw new NotImplementedException();
        
        /// <summary>
        ///     Создаёт файл
        /// </summary>
        /// <returns></returns>
        [HttpPost("{containerId}/{fileId}")]
        public IActionResult CreateFile(string containerId, string fileId) => throw new NotImplementedException();
        
        /// <summary>
        ///    Удаляет контейнер.
        /// </summary>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult DeleteContainer(string id) => throw new NotImplementedException();
        
        /// <summary>
        ///     Удаляет файл.
        /// </summary>
        /// <returns></returns>
        [HttpDelete("{containerId}/{fileId}")]
        public IActionResult DeleteFile(string containerId, string fileId) => throw new NotImplementedException();
    }
}