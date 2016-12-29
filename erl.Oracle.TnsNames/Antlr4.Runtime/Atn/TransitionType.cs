// Copyright (c) Terence Parr, Sam Harwell. All Rights Reserved.
// Licensed under the BSD License. See LICENSE.txt in the project root for license information.

using erl.Oracle.TnsNames.Antlr4.Runtime.Sharpen;

namespace erl.Oracle.TnsNames.Antlr4.Runtime.Atn
{
    public enum TransitionType
    {
        Invalid,
        Epsilon,
        Range,
        Rule,
        Predicate,
        Atom,
        Action,
        Set,
        NotSet,
        Wildcard,
        Precedence
    }
}