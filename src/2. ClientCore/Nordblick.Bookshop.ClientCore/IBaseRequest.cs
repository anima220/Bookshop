// #region License
// 
// //
// // Projekt : Nordblick.BookShop.ClientCore
// // Filename : IBaseRequest.cs
// // Erstellt am : 18.01.2021
// // Letztes CleanUp : 15:10
// // =====================================================================
// //
// // Copyright (c) 2021,  Thorsten Knoll Devcon-It
// //
// // All rights reserved. No part of this publication may be reproduced,
// // distributed, or transmitted in any form or by
// // any means, including photocopying, recording, or other
// // electronic or mechanical methods, without the prior
// // written permission of the programmer
// 
// #endregion

using System.Threading.Tasks;

namespace Nordblick.BookShop.ClientCore
{
    public interface IBaseRequest
    {
        string UrlPrefix { get; set; }

        Task<bool> DeleteAsync(string url);
        Task PostAsync(string url);
        Task PostAsync<T>(string url, T entity);
        Task<T> PostAsyncResponse<T>(string url, T entity);
        Task<T> PostAsync<T, U>(string url, U entity);
        Task PutAsync<T>(string url, T entity);
        Task<T> PutAsyncResponse<T>(string url, T entity);
    }
}