using System;

namespace Cosmos.IL2CPU.X86.IL
{
	[Cosmos.IL2CPU.OpCode(ILOpCode.Code.Ldind_R4)]
	public class Ldind_R4: ILOp
	{
		public Ldind_R4(ILOpCode aOpCode):base(aOpCode)
		{
		}

    public override void Execute(uint aMethodUID) {
      throw new Exception("TODO:");
    }

    #region Old code
		// using System;
		// 
		// using CPUx86 = Indy.IL2CPU.Assembler.X86;
		// using Indy.IL2CPU.Assembler;
		// 
		// namespace Indy.IL2CPU.IL.X86 {
		// 	[OpCode(OpCodeEnum.Ldind_R4)]
		// 	public class Ldind_R4: Op {
		// 		public Ldind_R4(ILReader aReader, MethodInformation aMethodInfo)
		// 			: base(aReader, aMethodInfo) {
		// 		}
		// 		public override void DoAssemble() {
		//             Assembler.StackContents.Pop();
		//             new CPUx86.Pop { DestinationReg = CPUx86.Registers.EAX };
		//             new CPUx86.Push { DestinationReg = CPUx86.Registers.EAX, DestinationIsIndirect=true, Size=32 };
		//             Assembler.StackContents.Push(new StackContent(4, typeof(Single)));
		// 		}
		// 	}
		// }
		#endregion Old code
	}
}
