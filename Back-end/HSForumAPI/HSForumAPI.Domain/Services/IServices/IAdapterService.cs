﻿using HSForumAPI.Domain.DTOs.PostDTOs;
using HSForumAPI.Domain.Models;

namespace HSForumAPI.Domain.Services.IServices
{
    public interface IAdapterService
    {
        Post Bind(PostRequest request, int userId);
    }
}