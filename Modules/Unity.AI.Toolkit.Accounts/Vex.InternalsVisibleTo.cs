// VEX FORK ADDITION (additive, merge-safe — upstream never touches this path).
// Grants the vex agent layer access to the points-balance state so it can open the Assistant chat input's
// points gate locally (the flue backend needs no Unity subscription). Submission still routes to our backend.
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Vex.Assistant.Editor")]
