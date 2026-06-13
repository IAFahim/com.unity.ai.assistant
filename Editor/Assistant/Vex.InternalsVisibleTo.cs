// VEX FORK ADDITION (additive, merge-safe — upstream never touches this path).
// Grants the vex agent layer access to ProviderStateObserver / AssistantProviderFactory so it can present the
// injected flue backend as a non-Unity provider (opening the chat input's points gate without a subscription).
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Vex.Assistant.Editor")]
