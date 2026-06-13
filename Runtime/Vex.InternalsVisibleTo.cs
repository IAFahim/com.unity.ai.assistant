// VEX FORK ADDITION (additive, merge-safe — upstream never touches this path).
// Grants the vex agent layer compile-time access to the internal backend surface
// (IAssistantBackend, IChatWorkflow, BackendResult, the data models) so it can
// route the Assistant to the user's own model via flue. This is the same
// InternalsVisibleTo mechanism the package already uses ~10× in this assembly.
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Vex.Assistant.Editor")]
