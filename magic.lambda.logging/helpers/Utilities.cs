﻿/*
 * Magic, Copyright(c) Thomas Hansen 2019 - 2020, thomas@servergardens.com, all rights reserved.
 * See the enclosed LICENSE file for details.
 */

using magic.node;
using magic.node.extensions;
using magic.signals.contracts;

namespace magic.lambda.logging.helpers
{
    internal static class Utilities
    {
        public static string GetLogContent(Node node, ISignaler signaler)
        {
            if (node.Value != null)
                return node.GetEx<string>();
            signaler.Signal("eval", node);
            string result = "";
            foreach (var idx in node.Children)
            {
                result += idx.GetEx<string>();
            }
            return result;
        }
    }
}
