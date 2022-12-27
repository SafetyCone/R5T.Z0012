using System;
using System.IO;

using R5T.T0132;


namespace R5T.Z0012
{
    [FunctionalityMarker]
    public partial interface IDirectoryNameOperator : IFunctionalityMarker
    {
        public bool IsNotBinariesOrObjectsDirectory(DirectoryInfo directoryInfo)
        {
            var output = true
                && directoryInfo.Name != Instances.DirectoryNames.bin
                && directoryInfo.Name != Instances.DirectoryNames.obj
                ;

            return output;
        }
    }
}
