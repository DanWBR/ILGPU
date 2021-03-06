﻿// -----------------------------------------------------------------------------
//                                    ILGPU
//                     Copyright (c) 2016-2018 Marcel Koester
//                                www.ilgpu.net
//
// File: DisassemblerDriver.cs
//
// This file is part of ILGPU and is distributed under the University of
// Illinois Open Source License. See LICENSE.txt for details
// -----------------------------------------------------------------------------

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ILGPU.Util;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Emit;

namespace ILGPU.Compiler
{
    sealed partial class DisassemblerContext
    {
        private delegate void OpCodeHandler(DisassemblerContext disassembler);
        private static readonly Dictionary<ILOpCode, OpCodeHandler> OpCodeHandlers = new Dictionary<ILOpCode, OpCodeHandler>();

        private delegate void PrefixHandler(DisassemblerContext disassembler);
        private static readonly Dictionary<ILOpCode, PrefixHandler> PrefixHandlers = new Dictionary<ILOpCode, PrefixHandler>();

        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline")]
        static DisassemblerContext()
        {
            InitOpCodeHandlers();
            InitPrefixHandlers();
        }

        [SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode")]
        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        static void InitOpCodeHandlers()
        {
            // Misc

            OpCodeHandlers.Add(ILOpCode.Nop, disassembler => disassembler.AppendInstruction(ILInstructionType.Nop, 0, 0));
            OpCodeHandlers.Add(ILOpCode.Break, disassembler => disassembler.AppendInstruction(ILInstructionType.Break, 0, 0));

            // Arguments

            OpCodeHandlers.Add(ILOpCode.Ldarg_0, disassembler => disassembler.AppendInstruction(ILInstructionType.Ldarg, 0, 1, 0));
            OpCodeHandlers.Add(ILOpCode.Ldarg_1, disassembler => disassembler.AppendInstruction(ILInstructionType.Ldarg, 0, 1, 1));
            OpCodeHandlers.Add(ILOpCode.Ldarg_2, disassembler => disassembler.AppendInstruction(ILInstructionType.Ldarg, 0, 1, 2));
            OpCodeHandlers.Add(ILOpCode.Ldarg_3, disassembler => disassembler.AppendInstruction(ILInstructionType.Ldarg, 0, 1, 3));
            OpCodeHandlers.Add(ILOpCode.Ldarg_S, disassembler => disassembler.AppendInstruction(ILInstructionType.Ldarg, 0, 1, disassembler.ReadByteArg()));
            OpCodeHandlers.Add(ILOpCode.Ldarg, disassembler => disassembler.AppendInstruction(ILInstructionType.Ldarg, 0, 1, disassembler.ReadUShortArg()));
            OpCodeHandlers.Add(ILOpCode.Ldarga_S, disassembler => disassembler.AppendInstruction(ILInstructionType.Ldarga, 0, 1, disassembler.ReadByteArg()));
            OpCodeHandlers.Add(ILOpCode.Ldarga, disassembler => disassembler.AppendInstruction(ILInstructionType.Ldarga, 0, 1, disassembler.ReadUShortArg()));
            OpCodeHandlers.Add(ILOpCode.Starg_S, disassembler => disassembler.AppendInstruction(ILInstructionType.Starg, 1, 0, disassembler.ReadByteArg()));
            OpCodeHandlers.Add(ILOpCode.Starg, disassembler => disassembler.AppendInstruction(ILInstructionType.Starg, 1, 0, disassembler.ReadUShortArg()));

            // Locals

            OpCodeHandlers.Add(ILOpCode.Ldloc_0, disassembler => disassembler.AppendInstruction(ILInstructionType.Ldloc, 0, 1, 0));
            OpCodeHandlers.Add(ILOpCode.Ldloc_1, disassembler => disassembler.AppendInstruction(ILInstructionType.Ldloc, 0, 1, 1));
            OpCodeHandlers.Add(ILOpCode.Ldloc_2, disassembler => disassembler.AppendInstruction(ILInstructionType.Ldloc, 0, 1, 2));
            OpCodeHandlers.Add(ILOpCode.Ldloc_3, disassembler => disassembler.AppendInstruction(ILInstructionType.Ldloc, 0, 1, 3));
            OpCodeHandlers.Add(ILOpCode.Ldloc_S, disassembler => disassembler.AppendInstruction(ILInstructionType.Ldloc, 0, 1, disassembler.ReadByteArg()));
            OpCodeHandlers.Add(ILOpCode.Ldloc, disassembler => disassembler.AppendInstruction(ILInstructionType.Ldloc, 0, 1, disassembler.ReadUShortArg()));
            OpCodeHandlers.Add(ILOpCode.Ldloca_S, disassembler => disassembler.AppendInstruction(ILInstructionType.Ldloca, 0, 1, disassembler.ReadByteArg()));
            OpCodeHandlers.Add(ILOpCode.Ldloca, disassembler => disassembler.AppendInstruction(ILInstructionType.Ldloca, 0, 1, disassembler.ReadUShortArg()));
            OpCodeHandlers.Add(ILOpCode.Stloc_0, disassembler => disassembler.AppendInstruction(ILInstructionType.Stloc, 1, 0, 0));
            OpCodeHandlers.Add(ILOpCode.Stloc_1, disassembler => disassembler.AppendInstruction(ILInstructionType.Stloc, 1, 0, 1));
            OpCodeHandlers.Add(ILOpCode.Stloc_2, disassembler => disassembler.AppendInstruction(ILInstructionType.Stloc, 1, 0, 2));
            OpCodeHandlers.Add(ILOpCode.Stloc_3, disassembler => disassembler.AppendInstruction(ILInstructionType.Stloc, 1, 0, 3));
            OpCodeHandlers.Add(ILOpCode.Stloc_S, disassembler => disassembler.AppendInstruction(ILInstructionType.Stloc, 1, 0, disassembler.ReadByteArg()));
            OpCodeHandlers.Add(ILOpCode.Stloc, disassembler => disassembler.AppendInstruction(ILInstructionType.Stloc, 1, 0, disassembler.ReadUShortArg()));

            // Constants

            OpCodeHandlers.Add(ILOpCode.Ldnull, disassembler => disassembler.AppendInstruction(ILInstructionType.Ldnull, 0, 1));
            OpCodeHandlers.Add(ILOpCode.Ldc_I4_M1, disassembler => disassembler.AppendInstruction(ILInstructionType.LdI4, 0, 1, -1));
            OpCodeHandlers.Add(ILOpCode.Ldc_I4_0, disassembler => disassembler.AppendInstruction(ILInstructionType.LdI4, 0, 1, 0));
            OpCodeHandlers.Add(ILOpCode.Ldc_I4_1, disassembler => disassembler.AppendInstruction(ILInstructionType.LdI4, 0, 1, 1));
            OpCodeHandlers.Add(ILOpCode.Ldc_I4_2, disassembler => disassembler.AppendInstruction(ILInstructionType.LdI4, 0, 1, 2));
            OpCodeHandlers.Add(ILOpCode.Ldc_I4_3, disassembler => disassembler.AppendInstruction(ILInstructionType.LdI4, 0, 1, 3));
            OpCodeHandlers.Add(ILOpCode.Ldc_I4_4, disassembler => disassembler.AppendInstruction(ILInstructionType.LdI4, 0, 1, 4));
            OpCodeHandlers.Add(ILOpCode.Ldc_I4_5, disassembler => disassembler.AppendInstruction(ILInstructionType.LdI4, 0, 1, 5));
            OpCodeHandlers.Add(ILOpCode.Ldc_I4_6, disassembler => disassembler.AppendInstruction(ILInstructionType.LdI4, 0, 1, 6));
            OpCodeHandlers.Add(ILOpCode.Ldc_I4_7, disassembler => disassembler.AppendInstruction(ILInstructionType.LdI4, 0, 1, 7));
            OpCodeHandlers.Add(ILOpCode.Ldc_I4_8, disassembler => disassembler.AppendInstruction(ILInstructionType.LdI4, 0, 1, 8));
            OpCodeHandlers.Add(ILOpCode.Ldc_I4_S, disassembler => disassembler.AppendInstruction(ILInstructionType.LdI4, 0, 1, disassembler.ReadSByteArg()));
            OpCodeHandlers.Add(ILOpCode.Ldc_I4, disassembler => disassembler.AppendInstruction(ILInstructionType.LdI4, 0, 1, disassembler.ReadIntArg()));
            OpCodeHandlers.Add(ILOpCode.Ldc_I8, disassembler => disassembler.AppendInstruction(ILInstructionType.LdI8, 0, 1, disassembler.ReadLongArg()));
            OpCodeHandlers.Add(ILOpCode.Ldc_R4, disassembler => disassembler.AppendInstruction(ILInstructionType.LdR4, 0, 1, disassembler.ReadSingleArg()));
            OpCodeHandlers.Add(ILOpCode.Ldc_R8, disassembler => disassembler.AppendInstruction(ILInstructionType.LdR8, 0, 1, disassembler.ReadDoubleArg()));
            OpCodeHandlers.Add(ILOpCode.Ldstr, disassembler => disassembler.AppendInstruction(ILInstructionType.Ldstr, 0, 1, disassembler.AssociatedModule.ResolveString(disassembler.ReadIntArg())));

            // Stack

            OpCodeHandlers.Add(ILOpCode.Dup, disassembler => disassembler.AppendInstruction(ILInstructionType.Dup, 1, 2));
            OpCodeHandlers.Add(ILOpCode.Pop, disassembler => disassembler.AppendInstruction(ILInstructionType.Pop, 1, 0));

            // Call

            OpCodeHandlers.Add(ILOpCode.Jmp, disassembler => disassembler.AppendInstruction(ILInstructionType.Jmp, 0, 0, disassembler.ResolveMethod(disassembler.ReadIntArg())));
            OpCodeHandlers.Add(ILOpCode.Call, disassembler => disassembler.DisassembleCall(ILInstructionType.Call, disassembler.ReadIntArg()));
            OpCodeHandlers.Add(ILOpCode.Callvirt, disassembler => disassembler.DisassembleCall(ILInstructionType.Callvirt, disassembler.ReadIntArg()));

            OpCodeHandlers.Add(ILOpCode.Ret, disassembler => disassembler.AppendInstruction(ILInstructionType.Ret, (ushort)disassembler.MethodBase.GetParameterOffset(), 0, OpCodes.Ret));

            // Branch

            OpCodeHandlers.Add(ILOpCode.Br_S, disassembler => disassembler.AppendInstruction(ILInstructionType.Br, 0, 0, new ILInstructionBranchTargets(disassembler.ReadShortBranchTarget())));
            OpCodeHandlers.Add(ILOpCode.Br, disassembler => disassembler.AppendInstruction(ILInstructionType.Br, 0, 0, new ILInstructionBranchTargets(disassembler.ReadBranchTarget())));
            OpCodeHandlers.Add(ILOpCode.Brfalse_S, disassembler => disassembler.AppendInstruction(ILInstructionType.Brfalse, 1, 0, new ILInstructionBranchTargets(disassembler.ReadShortBranchTarget(), disassembler.ilOffset)));
            OpCodeHandlers.Add(ILOpCode.Brfalse, disassembler => disassembler.AppendInstruction(ILInstructionType.Brfalse, 1, 0, new ILInstructionBranchTargets(disassembler.ReadBranchTarget(), disassembler.ilOffset)));
            OpCodeHandlers.Add(ILOpCode.Brtrue_S, disassembler => disassembler.AppendInstruction(ILInstructionType.Brtrue, 1, 0, new ILInstructionBranchTargets(disassembler.ReadShortBranchTarget(), disassembler.ilOffset)));
            OpCodeHandlers.Add(ILOpCode.Brtrue, disassembler => disassembler.AppendInstruction(ILInstructionType.Brtrue, 1, 0, new ILInstructionBranchTargets(disassembler.ReadBranchTarget(), disassembler.ilOffset)));

            OpCodeHandlers.Add(ILOpCode.Beq_S, disassembler => disassembler.AppendInstruction(ILInstructionType.Beq, 2, 0, new ILInstructionBranchTargets(disassembler.ReadShortBranchTarget(), disassembler.ilOffset)));
            OpCodeHandlers.Add(ILOpCode.Beq, disassembler => disassembler.AppendInstruction(ILInstructionType.Beq, 2, 0, new ILInstructionBranchTargets(disassembler.ReadBranchTarget(), disassembler.ilOffset)));
            OpCodeHandlers.Add(ILOpCode.Bge_S, disassembler => disassembler.AppendInstruction(ILInstructionType.Bge, 2, 0, new ILInstructionBranchTargets(disassembler.ReadShortBranchTarget(), disassembler.ilOffset)));
            OpCodeHandlers.Add(ILOpCode.Bge, disassembler => disassembler.AppendInstruction(ILInstructionType.Bge, 2, 0, new ILInstructionBranchTargets(disassembler.ReadBranchTarget(), disassembler.ilOffset)));
            OpCodeHandlers.Add(ILOpCode.Bgt_S, disassembler => disassembler.AppendInstruction(ILInstructionType.Bgt, 2, 0, new ILInstructionBranchTargets(disassembler.ReadShortBranchTarget(), disassembler.ilOffset)));
            OpCodeHandlers.Add(ILOpCode.Bgt, disassembler => disassembler.AppendInstruction(ILInstructionType.Bgt, 2, 0, new ILInstructionBranchTargets(disassembler.ReadBranchTarget(), disassembler.ilOffset)));
            OpCodeHandlers.Add(ILOpCode.Ble_S, disassembler => disassembler.AppendInstruction(ILInstructionType.Ble, 2, 0, new ILInstructionBranchTargets(disassembler.ReadShortBranchTarget(), disassembler.ilOffset)));
            OpCodeHandlers.Add(ILOpCode.Ble, disassembler => disassembler.AppendInstruction(ILInstructionType.Ble, 2, 0, new ILInstructionBranchTargets(disassembler.ReadBranchTarget(), disassembler.ilOffset)));
            OpCodeHandlers.Add(ILOpCode.Blt_S, disassembler => disassembler.AppendInstruction(ILInstructionType.Blt, 2, 0, new ILInstructionBranchTargets(disassembler.ReadShortBranchTarget(), disassembler.ilOffset)));
            OpCodeHandlers.Add(ILOpCode.Blt, disassembler => disassembler.AppendInstruction(ILInstructionType.Blt, 2, 0, new ILInstructionBranchTargets(disassembler.ReadBranchTarget(), disassembler.ilOffset)));

            OpCodeHandlers.Add(ILOpCode.Bne_Un_S, disassembler => disassembler.AppendInstructionWithFlags(ILInstructionType.Bne, 2, 0, ILInstructionFlags.Unsigned, new ILInstructionBranchTargets(disassembler.ReadShortBranchTarget(), disassembler.ilOffset)));
            OpCodeHandlers.Add(ILOpCode.Bne_Un, disassembler => disassembler.AppendInstructionWithFlags(ILInstructionType.Bne, 2, 0, ILInstructionFlags.Unsigned, new ILInstructionBranchTargets(disassembler.ReadBranchTarget(), disassembler.ilOffset)));
            OpCodeHandlers.Add(ILOpCode.Bge_Un_S, disassembler => disassembler.AppendInstructionWithFlags(ILInstructionType.Bge, 2, 0, ILInstructionFlags.Unsigned, new ILInstructionBranchTargets(disassembler.ReadShortBranchTarget(), disassembler.ilOffset)));
            OpCodeHandlers.Add(ILOpCode.Bge_Un, disassembler => disassembler.AppendInstructionWithFlags(ILInstructionType.Bge, 2, 0, ILInstructionFlags.Unsigned, new ILInstructionBranchTargets(disassembler.ReadBranchTarget(), disassembler.ilOffset)));
            OpCodeHandlers.Add(ILOpCode.Bgt_Un_S, disassembler => disassembler.AppendInstructionWithFlags(ILInstructionType.Bgt, 2, 0, ILInstructionFlags.Unsigned, new ILInstructionBranchTargets(disassembler.ReadShortBranchTarget(), disassembler.ilOffset)));
            OpCodeHandlers.Add(ILOpCode.Bgt_Un, disassembler => disassembler.AppendInstructionWithFlags(ILInstructionType.Bgt, 2, 0, ILInstructionFlags.Unsigned, new ILInstructionBranchTargets(disassembler.ReadBranchTarget(), disassembler.ilOffset)));
            OpCodeHandlers.Add(ILOpCode.Ble_Un_S, disassembler => disassembler.AppendInstructionWithFlags(ILInstructionType.Ble, 2, 0, ILInstructionFlags.Unsigned, new ILInstructionBranchTargets(disassembler.ReadShortBranchTarget(), disassembler.ilOffset)));
            OpCodeHandlers.Add(ILOpCode.Ble_Un, disassembler => disassembler.AppendInstructionWithFlags(ILInstructionType.Ble, 2, 0, ILInstructionFlags.Unsigned, new ILInstructionBranchTargets(disassembler.ReadBranchTarget(), disassembler.ilOffset)));
            OpCodeHandlers.Add(ILOpCode.Blt_Un_S, disassembler => disassembler.AppendInstructionWithFlags(ILInstructionType.Blt, 2, 0, ILInstructionFlags.Unsigned, new ILInstructionBranchTargets(disassembler.ReadShortBranchTarget(), disassembler.ilOffset)));
            OpCodeHandlers.Add(ILOpCode.Blt_Un, disassembler => disassembler.AppendInstructionWithFlags(ILInstructionType.Blt, 2, 0, ILInstructionFlags.Unsigned, new ILInstructionBranchTargets(disassembler.ReadBranchTarget(), disassembler.ilOffset)));

            OpCodeHandlers.Add(ILOpCode.Switch, disassembler =>
            {
                uint numSwitchTargets = disassembler.ReadUIntArg();
                int[] switchTargets = new int[numSwitchTargets + 1];
                var switchBaseOffset = switchTargets[0] = disassembler.ilOffset + sizeof(int) * (int)numSwitchTargets;
                for (int i = 0, e = (int)numSwitchTargets; i < e; ++i)
                    switchTargets[i + 1] = switchBaseOffset + disassembler.ReadIntArg();
                disassembler.AppendInstruction(ILInstructionType.Switch, 1, 0, new ILInstructionBranchTargets(switchTargets));
            });

            OpCodeHandlers.Add(ILOpCode.Add, disassembler => disassembler.AppendInstructionWithFlags(ILInstructionType.Add, 2, 1, ILInstructionFlags.None));
            OpCodeHandlers.Add(ILOpCode.Add_Ovf, disassembler => disassembler.AppendInstructionWithFlags(ILInstructionType.Add, 2, 1, ILInstructionFlags.Overflow));
            OpCodeHandlers.Add(ILOpCode.Add_Ovf_Un, disassembler => disassembler.AppendInstructionWithFlags(ILInstructionType.Add, 2, 1, ILInstructionFlags.Unsigned | ILInstructionFlags.Overflow));
            OpCodeHandlers.Add(ILOpCode.Sub, disassembler => disassembler.AppendInstructionWithFlags(ILInstructionType.Sub, 2, 1, ILInstructionFlags.None));
            OpCodeHandlers.Add(ILOpCode.Sub_Ovf, disassembler => disassembler.AppendInstructionWithFlags(ILInstructionType.Sub, 2, 1, ILInstructionFlags.Overflow));
            OpCodeHandlers.Add(ILOpCode.Sub_Ovf_Un, disassembler => disassembler.AppendInstructionWithFlags(ILInstructionType.Sub, 2, 1, ILInstructionFlags.Unsigned | ILInstructionFlags.Overflow));
            OpCodeHandlers.Add(ILOpCode.Mul, disassembler => disassembler.AppendInstructionWithFlags(ILInstructionType.Mul, 2, 1, ILInstructionFlags.None));
            OpCodeHandlers.Add(ILOpCode.Mul_Ovf, disassembler => disassembler.AppendInstructionWithFlags(ILInstructionType.Mul, 2, 1, ILInstructionFlags.Overflow));
            OpCodeHandlers.Add(ILOpCode.Mul_Ovf_Un, disassembler => disassembler.AppendInstructionWithFlags(ILInstructionType.Mul, 2, 1, ILInstructionFlags.Unsigned | ILInstructionFlags.Overflow));
            OpCodeHandlers.Add(ILOpCode.Div, disassembler => disassembler.AppendInstructionWithFlags(ILInstructionType.Div, 2, 1, ILInstructionFlags.None));
            OpCodeHandlers.Add(ILOpCode.Div_Un, disassembler => disassembler.AppendInstructionWithFlags(ILInstructionType.Div, 2, 1, ILInstructionFlags.Unsigned));
            OpCodeHandlers.Add(ILOpCode.Rem, disassembler => disassembler.AppendInstructionWithFlags(ILInstructionType.Rem, 2, 1, ILInstructionFlags.None));
            OpCodeHandlers.Add(ILOpCode.Rem_Un, disassembler => disassembler.AppendInstructionWithFlags(ILInstructionType.Rem, 2, 1, ILInstructionFlags.Unsigned));
            OpCodeHandlers.Add(ILOpCode.And, disassembler => disassembler.AppendInstructionWithFlags(ILInstructionType.And, 2, 1, ILInstructionFlags.None));
            OpCodeHandlers.Add(ILOpCode.Or, disassembler => disassembler.AppendInstructionWithFlags(ILInstructionType.Or, 2, 1, ILInstructionFlags.None));
            OpCodeHandlers.Add(ILOpCode.Xor, disassembler => disassembler.AppendInstructionWithFlags(ILInstructionType.Xor, 2, 1, ILInstructionFlags.None));
            OpCodeHandlers.Add(ILOpCode.Shl, disassembler => disassembler.AppendInstructionWithFlags(ILInstructionType.Shl, 2, 1, ILInstructionFlags.None));
            OpCodeHandlers.Add(ILOpCode.Shr, disassembler => disassembler.AppendInstructionWithFlags(ILInstructionType.Shr, 2, 1, ILInstructionFlags.None));
            OpCodeHandlers.Add(ILOpCode.Shr_Un, disassembler => disassembler.AppendInstructionWithFlags(ILInstructionType.Shr, 2, 1, ILInstructionFlags.Unsigned));
            OpCodeHandlers.Add(ILOpCode.Neg, disassembler => disassembler.AppendInstructionWithFlags(ILInstructionType.Neg, 1, 1, ILInstructionFlags.None));
            OpCodeHandlers.Add(ILOpCode.Not, disassembler => disassembler.AppendInstructionWithFlags(ILInstructionType.Not, 1, 1, ILInstructionFlags.None));

            // Conversion

            OpCodeHandlers.Add(ILOpCode.Conv_I1, disassembler => disassembler.AppendInstructionWithFlags(ILInstructionType.Conv, 1, 1, ILInstructionFlags.None, typeof(sbyte)));
            OpCodeHandlers.Add(ILOpCode.Conv_I2, disassembler => disassembler.AppendInstructionWithFlags(ILInstructionType.Conv, 1, 1, ILInstructionFlags.None, typeof(short)));
            OpCodeHandlers.Add(ILOpCode.Conv_I4, disassembler => disassembler.AppendInstructionWithFlags(ILInstructionType.Conv, 1, 1, ILInstructionFlags.None, typeof(int)));
            OpCodeHandlers.Add(ILOpCode.Conv_I8, disassembler => disassembler.AppendInstructionWithFlags(ILInstructionType.Conv, 1, 1, ILInstructionFlags.None, typeof(long)));
            OpCodeHandlers.Add(ILOpCode.Conv_I, disassembler => disassembler.AppendInstructionWithFlags(ILInstructionType.Conv, 1, 1, ILInstructionFlags.None, NativePtrType));

            OpCodeHandlers.Add(ILOpCode.Conv_Ovf_I1, disassembler => disassembler.AppendInstructionWithFlags(ILInstructionType.Conv, 1, 1, ILInstructionFlags.Overflow, typeof(sbyte)));
            OpCodeHandlers.Add(ILOpCode.Conv_Ovf_I2, disassembler => disassembler.AppendInstructionWithFlags(ILInstructionType.Conv, 1, 1, ILInstructionFlags.Overflow, typeof(short)));
            OpCodeHandlers.Add(ILOpCode.Conv_Ovf_I4, disassembler => disassembler.AppendInstructionWithFlags(ILInstructionType.Conv, 1, 1, ILInstructionFlags.Overflow, typeof(int)));
            OpCodeHandlers.Add(ILOpCode.Conv_Ovf_I8, disassembler => disassembler.AppendInstructionWithFlags(ILInstructionType.Conv, 1, 1, ILInstructionFlags.Overflow, typeof(long)));
            OpCodeHandlers.Add(ILOpCode.Conv_Ovf_I, disassembler => disassembler.AppendInstructionWithFlags(ILInstructionType.Conv, 1, 1, ILInstructionFlags.Overflow, NativePtrType));

            OpCodeHandlers.Add(ILOpCode.Conv_Ovf_I1_Un, disassembler => disassembler.AppendInstructionWithFlags(ILInstructionType.Conv, 1, 1, ILInstructionFlags.Overflow | ILInstructionFlags.Unsigned, typeof(sbyte)));
            OpCodeHandlers.Add(ILOpCode.Conv_Ovf_I2_Un, disassembler => disassembler.AppendInstructionWithFlags(ILInstructionType.Conv, 1, 1, ILInstructionFlags.Overflow | ILInstructionFlags.Unsigned, typeof(short)));
            OpCodeHandlers.Add(ILOpCode.Conv_Ovf_I4_Un, disassembler => disassembler.AppendInstructionWithFlags(ILInstructionType.Conv, 1, 1, ILInstructionFlags.Overflow | ILInstructionFlags.Unsigned, typeof(int)));
            OpCodeHandlers.Add(ILOpCode.Conv_Ovf_I8_Un, disassembler => disassembler.AppendInstructionWithFlags(ILInstructionType.Conv, 1, 1, ILInstructionFlags.Overflow | ILInstructionFlags.Unsigned, typeof(long)));
            OpCodeHandlers.Add(ILOpCode.Conv_Ovf_I_Un, disassembler => disassembler.AppendInstructionWithFlags(ILInstructionType.Conv, 1, 1, ILInstructionFlags.Overflow | ILInstructionFlags.Unsigned, NativePtrType));

            OpCodeHandlers.Add(ILOpCode.Conv_R4, disassembler => disassembler.AppendInstructionWithFlags(ILInstructionType.Conv, 1, 1, ILInstructionFlags.None, typeof(float)));
            OpCodeHandlers.Add(ILOpCode.Conv_R8, disassembler => disassembler.AppendInstructionWithFlags(ILInstructionType.Conv, 1, 1, ILInstructionFlags.None, typeof(double)));
            OpCodeHandlers.Add(ILOpCode.Conv_R_Un, disassembler => disassembler.AppendInstructionWithFlags(ILInstructionType.Conv, 1, 1, ILInstructionFlags.Unsigned, typeof(double)));

            OpCodeHandlers.Add(ILOpCode.Conv_U1, disassembler => disassembler.AppendInstructionWithFlags(ILInstructionType.Conv, 1, 1, ILInstructionFlags.None, typeof(byte)));
            OpCodeHandlers.Add(ILOpCode.Conv_U2, disassembler => disassembler.AppendInstructionWithFlags(ILInstructionType.Conv, 1, 1, ILInstructionFlags.None, typeof(ushort)));
            OpCodeHandlers.Add(ILOpCode.Conv_U4, disassembler => disassembler.AppendInstructionWithFlags(ILInstructionType.Conv, 1, 1, ILInstructionFlags.None, typeof(uint)));
            OpCodeHandlers.Add(ILOpCode.Conv_U8, disassembler => disassembler.AppendInstructionWithFlags(ILInstructionType.Conv, 1, 1, ILInstructionFlags.None, typeof(ulong)));
            OpCodeHandlers.Add(ILOpCode.Conv_U, disassembler => disassembler.AppendInstructionWithFlags(ILInstructionType.Conv, 1, 1, ILInstructionFlags.None, NativePtrType));

            OpCodeHandlers.Add(ILOpCode.Conv_Ovf_U1, disassembler => disassembler.AppendInstructionWithFlags(ILInstructionType.Conv, 1, 1, ILInstructionFlags.Overflow, typeof(byte)));
            OpCodeHandlers.Add(ILOpCode.Conv_Ovf_U2, disassembler => disassembler.AppendInstructionWithFlags(ILInstructionType.Conv, 1, 1, ILInstructionFlags.Overflow, typeof(ushort)));
            OpCodeHandlers.Add(ILOpCode.Conv_Ovf_U4, disassembler => disassembler.AppendInstructionWithFlags(ILInstructionType.Conv, 1, 1, ILInstructionFlags.Overflow, typeof(uint)));
            OpCodeHandlers.Add(ILOpCode.Conv_Ovf_U8, disassembler => disassembler.AppendInstructionWithFlags(ILInstructionType.Conv, 1, 1, ILInstructionFlags.Overflow, typeof(ulong)));
            OpCodeHandlers.Add(ILOpCode.Conv_Ovf_U, disassembler => disassembler.AppendInstructionWithFlags(ILInstructionType.Conv, 1, 1, ILInstructionFlags.Overflow, NativePtrType));

            OpCodeHandlers.Add(ILOpCode.Conv_Ovf_U1_Un, disassembler => disassembler.AppendInstructionWithFlags(ILInstructionType.Conv, 1, 1, ILInstructionFlags.Overflow | ILInstructionFlags.Unsigned, typeof(byte)));
            OpCodeHandlers.Add(ILOpCode.Conv_Ovf_U2_Un, disassembler => disassembler.AppendInstructionWithFlags(ILInstructionType.Conv, 1, 1, ILInstructionFlags.Overflow | ILInstructionFlags.Unsigned, typeof(ushort)));
            OpCodeHandlers.Add(ILOpCode.Conv_Ovf_U4_Un, disassembler => disassembler.AppendInstructionWithFlags(ILInstructionType.Conv, 1, 1, ILInstructionFlags.Overflow | ILInstructionFlags.Unsigned, typeof(uint)));
            OpCodeHandlers.Add(ILOpCode.Conv_Ovf_U8_Un, disassembler => disassembler.AppendInstructionWithFlags(ILInstructionType.Conv, 1, 1, ILInstructionFlags.Overflow | ILInstructionFlags.Unsigned, typeof(ulong)));
            OpCodeHandlers.Add(ILOpCode.Conv_Ovf_U_Un, disassembler => disassembler.AppendInstructionWithFlags(ILInstructionType.Conv, 1, 1, ILInstructionFlags.Overflow | ILInstructionFlags.Unsigned, NativePtrType));

            // General Object

            OpCodeHandlers.Add(ILOpCode.Initobj, disassembler => disassembler.AppendInstruction(ILInstructionType.Initobj, 1, 0, disassembler.ReadTypeArg()));
            OpCodeHandlers.Add(ILOpCode.Newobj, disassembler => disassembler.DisassembleCall(ILInstructionType.Newobj, disassembler.ReadIntArg()));
            OpCodeHandlers.Add(ILOpCode.Newarr, disassembler => disassembler.AppendInstruction(ILInstructionType.Newarr, 1, 1, disassembler.ReadTypeArg()));

            // Boxing

            OpCodeHandlers.Add(ILOpCode.Box, disassembler => disassembler.AppendInstruction(ILInstructionType.Box, 1, 1, disassembler.ReadTypeArg()));
            OpCodeHandlers.Add(ILOpCode.Unbox, disassembler => disassembler.AppendInstruction(ILInstructionType.Unbox, 1, 1, disassembler.ReadTypeArg()));
            OpCodeHandlers.Add(ILOpCode.Unbox_Any, disassembler =>
            {
                var type = disassembler.ResolveType(disassembler.ReadIntArg());
                disassembler.AppendInstruction(ILInstructionType.Unbox, 1, 1, type);
                disassembler.AppendInstruction(ILInstructionType.Ldobj, 1, 1, type);
            });

            OpCodeHandlers.Add(ILOpCode.Castclass, disassembler => disassembler.AppendInstruction(ILInstructionType.Castclass, 1, 1, disassembler.ReadTypeArg()));
            OpCodeHandlers.Add(ILOpCode.Isinst, disassembler => disassembler.AppendInstruction(ILInstructionType.Isinst, 1, 1, disassembler.ReadTypeArg()));

            // Fields

            OpCodeHandlers.Add(ILOpCode.Ldfld, disassembler => disassembler.AppendInstruction(ILInstructionType.Ldfld, 1, 1, disassembler.ReadFieldArg()));
            OpCodeHandlers.Add(ILOpCode.Ldflda, disassembler => disassembler.AppendInstruction(ILInstructionType.Ldflda, 1, 1, disassembler.ReadFieldArg()));
            OpCodeHandlers.Add(ILOpCode.Ldsfld, disassembler => disassembler.AppendInstruction(ILInstructionType.Ldsfld, 0, 1, disassembler.ReadFieldArg()));
            OpCodeHandlers.Add(ILOpCode.Ldsflda, disassembler => disassembler.AppendInstruction(ILInstructionType.Ldsflda, 0, 1, disassembler.ReadFieldArg()));
            OpCodeHandlers.Add(ILOpCode.Stfld, disassembler => disassembler.AppendInstruction(ILInstructionType.Stfld, 2, 0, disassembler.ReadFieldArg()));
            OpCodeHandlers.Add(ILOpCode.Stsfld, disassembler => disassembler.AppendInstruction(ILInstructionType.Stsfld, 1, 0, disassembler.ReadFieldArg()));

            // Indirect objects

            OpCodeHandlers.Add(ILOpCode.Ldobj, disassembler => disassembler.AppendInstruction(ILInstructionType.Ldobj, 1, 1, disassembler.ReadTypeArg()));
            OpCodeHandlers.Add(ILOpCode.Stobj, disassembler => disassembler.AppendInstruction(ILInstructionType.Stobj, 1, 1, disassembler.ReadTypeArg()));
            OpCodeHandlers.Add(ILOpCode.Cpobj, disassembler => disassembler.AppendInstruction(ILInstructionType.Cpobj, 2, 0, disassembler.ReadTypeArg()));

            // Arrays

            OpCodeHandlers.Add(ILOpCode.Ldlen, disassembler => disassembler.AppendInstruction(ILInstructionType.Ldlen, 1, 1));

            OpCodeHandlers.Add(ILOpCode.Ldelem_I1, disassembler => disassembler.AppendInstruction(ILInstructionType.Ldelem, 2, 1, typeof(sbyte)));
            OpCodeHandlers.Add(ILOpCode.Ldelem_U1, disassembler => disassembler.AppendInstruction(ILInstructionType.Ldelem, 2, 1, typeof(byte)));
            OpCodeHandlers.Add(ILOpCode.Ldelem_I2, disassembler => disassembler.AppendInstruction(ILInstructionType.Ldelem, 2, 1, typeof(short)));
            OpCodeHandlers.Add(ILOpCode.Ldelem_U2, disassembler => disassembler.AppendInstruction(ILInstructionType.Ldelem, 2, 1, typeof(ushort)));
            OpCodeHandlers.Add(ILOpCode.Ldelem_I4, disassembler => disassembler.AppendInstruction(ILInstructionType.Ldelem, 2, 1, typeof(int)));
            OpCodeHandlers.Add(ILOpCode.Ldelem_U4, disassembler => disassembler.AppendInstruction(ILInstructionType.Ldelem, 2, 1, typeof(uint)));
            OpCodeHandlers.Add(ILOpCode.Ldelem_I8, disassembler => disassembler.AppendInstruction(ILInstructionType.Ldelem, 2, 1, typeof(long)));
            OpCodeHandlers.Add(ILOpCode.Ldelem_R4, disassembler => disassembler.AppendInstruction(ILInstructionType.Ldelem, 2, 1, typeof(float)));
            OpCodeHandlers.Add(ILOpCode.Ldelem_R8, disassembler => disassembler.AppendInstruction(ILInstructionType.Ldelem, 2, 1, typeof(double)));
            OpCodeHandlers.Add(ILOpCode.Ldelem_Ref, disassembler => disassembler.AppendInstruction(ILInstructionType.Ldelem, 2, 1, disassembler.ReadTypeArg()));
            OpCodeHandlers.Add(ILOpCode.Ldelem_I, disassembler => disassembler.AppendInstruction(ILInstructionType.Ldelem, 2, 1, NativePtrType));
            OpCodeHandlers.Add(ILOpCode.Ldelema, disassembler => disassembler.AppendInstruction(ILInstructionType.Ldelema, 2, 1));

            OpCodeHandlers.Add(ILOpCode.Stelem_I1, disassembler => disassembler.AppendInstruction(ILInstructionType.Stelem, 3, 0, typeof(sbyte)));
            OpCodeHandlers.Add(ILOpCode.Stelem_I2, disassembler => disassembler.AppendInstruction(ILInstructionType.Stelem, 3, 0, typeof(short)));
            OpCodeHandlers.Add(ILOpCode.Stelem_I4, disassembler => disassembler.AppendInstruction(ILInstructionType.Stelem, 3, 0, typeof(int)));
            OpCodeHandlers.Add(ILOpCode.Stelem_I8, disassembler => disassembler.AppendInstruction(ILInstructionType.Stelem, 3, 0, typeof(long)));
            OpCodeHandlers.Add(ILOpCode.Stelem_R4, disassembler => disassembler.AppendInstruction(ILInstructionType.Stelem, 3, 0, typeof(float)));
            OpCodeHandlers.Add(ILOpCode.Stelem_R8, disassembler => disassembler.AppendInstruction(ILInstructionType.Stelem, 3, 0, typeof(double)));
            OpCodeHandlers.Add(ILOpCode.Stelem_I, disassembler => disassembler.AppendInstruction(ILInstructionType.Stelem, 3, 0, typeof(void).MakePointerType()));
            OpCodeHandlers.Add(ILOpCode.Stelem_Ref, disassembler => disassembler.AppendInstruction(ILInstructionType.Stelem, 3, 0, disassembler.ReadTypeArg()));

            // Compare

            OpCodeHandlers.Add(ILOpCode.Ceq, disassembler => disassembler.AppendInstructionWithFlags(ILInstructionType.Ceq, 2, 1, ILInstructionFlags.None));
            OpCodeHandlers.Add(ILOpCode.Cgt, disassembler => disassembler.AppendInstructionWithFlags(ILInstructionType.Cgt, 2, 1, ILInstructionFlags.None));
            OpCodeHandlers.Add(ILOpCode.Cgt_Un, disassembler => disassembler.AppendInstructionWithFlags(ILInstructionType.Cgt, 2, 1, ILInstructionFlags.Unsigned));
            OpCodeHandlers.Add(ILOpCode.Clt, disassembler => disassembler.AppendInstructionWithFlags(ILInstructionType.Clt, 2, 1, ILInstructionFlags.None));
            OpCodeHandlers.Add(ILOpCode.Clt_Un, disassembler => disassembler.AppendInstructionWithFlags(ILInstructionType.Clt, 2, 1, ILInstructionFlags.Unsigned));

            // Indirect

            OpCodeHandlers.Add(ILOpCode.Ldind_I1, disassembler => disassembler.AppendInstruction(ILInstructionType.Ldind, 1, 1, typeof(sbyte)));
            OpCodeHandlers.Add(ILOpCode.Ldind_I2, disassembler => disassembler.AppendInstruction(ILInstructionType.Ldind, 1, 1, typeof(short)));
            OpCodeHandlers.Add(ILOpCode.Ldind_I4, disassembler => disassembler.AppendInstruction(ILInstructionType.Ldind, 1, 1, typeof(int)));
            OpCodeHandlers.Add(ILOpCode.Ldind_I8, disassembler => disassembler.AppendInstruction(ILInstructionType.Ldind, 1, 1, typeof(long)));
            OpCodeHandlers.Add(ILOpCode.Ldind_U1, disassembler => disassembler.AppendInstruction(ILInstructionType.Ldind, 1, 1, typeof(byte)));
            OpCodeHandlers.Add(ILOpCode.Ldind_U2, disassembler => disassembler.AppendInstruction(ILInstructionType.Ldind, 1, 1, typeof(ushort)));
            OpCodeHandlers.Add(ILOpCode.Ldind_U4, disassembler => disassembler.AppendInstruction(ILInstructionType.Ldind, 1, 1, typeof(uint)));
            OpCodeHandlers.Add(ILOpCode.Ldind_R4, disassembler => disassembler.AppendInstruction(ILInstructionType.Ldind, 1, 1, typeof(float)));
            OpCodeHandlers.Add(ILOpCode.Ldind_R8, disassembler => disassembler.AppendInstruction(ILInstructionType.Ldind, 1, 1, typeof(double)));
            OpCodeHandlers.Add(ILOpCode.Ldind_I, disassembler => disassembler.AppendInstruction(ILInstructionType.Ldind, 1, 1, NativePtrType));
            OpCodeHandlers.Add(ILOpCode.Ldind_Ref, disassembler => disassembler.AppendInstruction(ILInstructionType.Ldind, 1, 1, disassembler.ReadTypeArg()));

            OpCodeHandlers.Add(ILOpCode.Stind_I1, disassembler => disassembler.AppendInstruction(ILInstructionType.Stind, 2, 0, typeof(byte)));
            OpCodeHandlers.Add(ILOpCode.Stind_I2, disassembler => disassembler.AppendInstruction(ILInstructionType.Stind, 2, 0, typeof(short)));
            OpCodeHandlers.Add(ILOpCode.Stind_I4, disassembler => disassembler.AppendInstruction(ILInstructionType.Stind, 2, 0, typeof(int)));
            OpCodeHandlers.Add(ILOpCode.Stind_I8, disassembler => disassembler.AppendInstruction(ILInstructionType.Stind, 2, 0, typeof(long)));
            OpCodeHandlers.Add(ILOpCode.Stind_R4, disassembler => disassembler.AppendInstruction(ILInstructionType.Stind, 2, 0, typeof(float)));
            OpCodeHandlers.Add(ILOpCode.Stind_R8, disassembler => disassembler.AppendInstruction(ILInstructionType.Stind, 2, 0, typeof(double)));
            OpCodeHandlers.Add(ILOpCode.Stind_I, disassembler => disassembler.AppendInstruction(ILInstructionType.Stind, 2, 0, NativePtrType));
            OpCodeHandlers.Add(ILOpCode.Stind_Ref, disassembler => disassembler.AppendInstruction(ILInstructionType.Stind, 2, 0, disassembler.ReadTypeArg()));

            OpCodeHandlers.Add(ILOpCode.Localloc, disassembler => disassembler.AppendInstruction(ILInstructionType.Localloc, 1, 1, disassembler.ReadTypeArg()));

            // Blk

            OpCodeHandlers.Add(ILOpCode.Cpblk, disassembler => disassembler.AppendInstruction(ILInstructionType.Cpblk, 3, 0));
            OpCodeHandlers.Add(ILOpCode.Initblk, disassembler => disassembler.AppendInstruction(ILInstructionType.Initblk, 3, 0));

            // SizeOf
            
            OpCodeHandlers.Add(ILOpCode.Sizeof, disassembler => disassembler.AppendInstruction(ILInstructionType.SizeOf, 0, 1, disassembler.ReadTypeArg()));
        }

        static void InitPrefixHandlers()
        {
            PrefixHandlers.Add(ILOpCode.No, disassembler => disassembler.AddFlags(ILInstructionFlags.Unchecked));
            PrefixHandlers.Add(ILOpCode.Unaligned, disassembler => disassembler.AddFlags(ILInstructionFlags.Unaligned));
            PrefixHandlers.Add(ILOpCode.Volatile, disassembler => disassembler.AddFlags(ILInstructionFlags.Volatile));
            PrefixHandlers.Add(ILOpCode.Readonly, disassembler => disassembler.AddFlags(ILInstructionFlags.ReadOnly));
            PrefixHandlers.Add(ILOpCode.Tail, disassembler => disassembler.AddFlags(ILInstructionFlags.Tail));
            PrefixHandlers.Add(ILOpCode.Constrained, disassembler =>
            {
                disassembler.AddFlags(ILInstructionFlags.Constrained);
                disassembler.flagsArgument = disassembler.ReadTypeArg();
            });
        }
    }
}
