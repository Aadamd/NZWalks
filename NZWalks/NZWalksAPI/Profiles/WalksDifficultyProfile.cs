using System;
using AutoMapper;
namespace NZWalksAPI.Profiles
{
	public class WalksDifficultyProfile: Profile
	{
		public WalksDifficultyProfile()
		{
            CreateMap<Models.Domain.WalkDifficulty, Models.DTO.WalkDifficulty>()
                .ReverseMap();
        }
	}
}

