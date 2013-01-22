using System;

namespace SpecsFor.Configuration.Model
{
	internal interface IConditionalBehavior
	{
		bool CanBeAppliedTo(Type targetType);
		void ApplyGivenTo(object specs);
		void ApplyAfterSpecTo(object specs);
		void ApplySpecInitTo(object specs);
		void ApplyAfterClassUnderTestInitializedTo(object specs);
	}
}