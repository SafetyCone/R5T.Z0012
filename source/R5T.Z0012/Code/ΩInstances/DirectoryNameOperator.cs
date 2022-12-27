using System;


namespace R5T.Z0012
{
    public class DirectoryNameOperator : IDirectoryNameOperator
    {
        #region Infrastructure

        public static IDirectoryNameOperator Instance { get; } = new DirectoryNameOperator();


        private DirectoryNameOperator()
        {
        }

        #endregion
    }
}
