using System;
using FluentValidation;

namespace NZWalksAPI.Validators
{
	public class UpdateWalkDifficultyValidator : AbstractValidator<Models.DTO.UpdateWalkDifficulty>
	{
		public UpdateWalkDifficultyValidator()
		{
            RuleFor(x => x.Code).NotEmpty();
        }
	}
}

