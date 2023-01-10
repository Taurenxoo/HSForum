﻿using HSForumAPI.Domain.DTOs.PostDTOs;
using HSForumAPI.Domain.DTOs.PostReplyDTOs;
using HSForumAPI.Domain.DTOs.RatingDTOs;
using HSForumAPI.Domain.Models;

namespace HSForumAPI.Domain.Services.IServices
{
    public interface IAdapterService
    {
        Post Bind(PostRequest request, int userId);
        PostResponse Bind(Post post);
        PostReplyResponse Bind(PostReply reply);
        PostReply Bind(PostReplyRequest request, int userId);
        Rating Bind(RatingRequest request, int userId);
        RatingResponse Bind(Rating rating);
    }
}
