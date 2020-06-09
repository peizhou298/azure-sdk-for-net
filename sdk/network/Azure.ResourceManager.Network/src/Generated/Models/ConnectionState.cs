// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The connection state. </summary>
    public readonly partial struct ConnectionState : IEquatable<ConnectionState>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="ConnectionState"/> values are the same. </summary>
        public ConnectionState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ReachableValue = "Reachable";
        private const string UnreachableValue = "Unreachable";
        private const string UnknownValue = "Unknown";

        /// <summary> Reachable. </summary>
        public static ConnectionState Reachable { get; } = new ConnectionState(ReachableValue);
        /// <summary> Unreachable. </summary>
        public static ConnectionState Unreachable { get; } = new ConnectionState(UnreachableValue);
        /// <summary> Unknown. </summary>
        public static ConnectionState Unknown { get; } = new ConnectionState(UnknownValue);
        /// <summary> Determines if two <see cref="ConnectionState"/> values are the same. </summary>
        public static bool operator ==(ConnectionState left, ConnectionState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ConnectionState"/> values are not the same. </summary>
        public static bool operator !=(ConnectionState left, ConnectionState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ConnectionState"/>. </summary>
        public static implicit operator ConnectionState(string value) => new ConnectionState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ConnectionState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ConnectionState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}