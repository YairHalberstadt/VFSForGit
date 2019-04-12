﻿using System;
using System.IO;
using GVFS.Common;
using GVFS.Common.Git;
using GVFS.Virtualization.FileSystem;

namespace GVFS.UnitTests.Mock.Virtualization.FileSystem
{
    public class MockFileSystemVirtualizer : FileSystemVirtualizer
    {
        public MockFileSystemVirtualizer(GVFSContext context, GVFSGitObjects gvfsGitObjects)
            : base(context, gvfsGitObjects)
        {
        }

        public override FileSystemResult ClearNegativePathCache(out uint totalEntryCount)
        {
            totalEntryCount = 0;
            return new FileSystemResult(FSResult.Ok, rawResult: 0);
        }

        public override FileSystemResult DeleteFile(string relativePath, UpdatePlaceholderType updateFlags, out UpdateFailureReason failureReason)
        {
            throw new NotImplementedException();
        }

        public override void Stop()
        {
        }

        public override FileSystemResult WritePlaceholderFile(string relativePath, long endOfFile, string sha)
        {
            throw new NotImplementedException();
        }

        public override FileSystemResult WritePlaceholderDirectory(string relativePath)
        {
            throw new NotImplementedException();
        }

        public override FileSystemResult UpdatePlaceholderIfNeeded(string relativePath, DateTime creationTime, DateTime lastAccessTime, DateTime lastWriteTime, DateTime changeTime, FileAttributes fileAttributes, long endOfFile, string shaContentId, UpdatePlaceholderType updateFlags, out UpdateFailureReason failureReason)
        {
            throw new NotImplementedException();
        }

        protected override bool TryStart(out string error)
        {
            error = null;
            return true;
        }

        protected override void OnFileDeleteNotification(string relativePath)
        {
            throw new NotImplementedException();
        }

        protected override void OnFolderDeleteNotification(string relativePath, bool isGitCommandRunning)
        {
            throw new NotImplementedException();
        }
    }
}
