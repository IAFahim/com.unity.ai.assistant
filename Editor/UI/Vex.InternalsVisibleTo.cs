// VEX FORK ADDITION (additive, merge-safe — upstream never touches this path).
// Grants the vex agent layer access to AssistantWindow.InternalConfigureBackend,
// the designed override hook that runs the window on an injected IAssistantBackend.
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Vex.Assistant.Editor")]
