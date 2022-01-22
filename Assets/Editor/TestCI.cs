using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using Unity.Options;

public static class TestCI
{
    [MenuItem("TestCI/Test1")]
    public static void Test1()
    {
        var commandLine = new[]
            {
                "--char-list=1,a",
                "--byte-list=2,22",
                "--s-byte-list=3,33",
                "--short-list=4,44",
                "--u-short-list=5,55",
                "--int-list=6,66",
                "--u-int-list=7,77",
                "--long-list=8,88",
                "--u-long-list=9,99",
                "--float-list=10.42,1042.1042",
                "--double-list=11.33,1133.1133",
                "--bool-list=false,true",
                "--string-list=gabriele farina,ralph hauwert"
            };
        var types = new[] { typeof(ListBasicTypesOptions) };

        OptionsParser.Prepare(commandLine, types);

        var t = ListBasicTypesOptions.BoolList;
        Debug.Log(t[0]);
    }
}

[ProgramOptions]
public sealed class ListBasicTypesOptions
{
    public static List<char> CharList;
    public static List<byte> ByteList;
    public static List<sbyte> SByteList;
    public static List<short> ShortList;
    public static List<ushort> UShortList;
    public static List<int> IntList;
    public static List<uint> UIntList;
    public static List<long> LongList;
    public static List<ulong> ULongList;
    public static List<float> FloatList;
    public static List<double> DoubleList;
    public static List<bool> BoolList;
    public static List<string> StringList;
}