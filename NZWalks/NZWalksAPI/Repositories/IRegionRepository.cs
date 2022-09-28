using System;
using System.Collections;
using System.Collections.Generic;
using NZWalksAPI.Models.Domain;

namespace NZWalksAPI.Repositories
{
	public interface IRegionRepository
	{
		Task<IEnumerable<Region>> GetAllAsync();
	}
}

