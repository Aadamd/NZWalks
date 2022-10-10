using System;
using FluentValidation;

namespace NZWalksAPI.Validators
{
	public class AddWalkDifficultyValidator : AbstractValidator<Models.DTO.UpdateWalkDifficulty>
    {
		public AddWalkDifficultyValidator()
		{
			RuleFor(x => x.Code).NotEmpty();
		}
	}
}

