// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package computeinstanceagent

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

type GetInstanceAgentPluginsFilter struct {
	// The plugin name
	Name   string   `pulumi:"name"`
	Regex  *bool    `pulumi:"regex"`
	Values []string `pulumi:"values"`
}

// GetInstanceAgentPluginsFilterInput is an input type that accepts GetInstanceAgentPluginsFilterArgs and GetInstanceAgentPluginsFilterOutput values.
// You can construct a concrete instance of `GetInstanceAgentPluginsFilterInput` via:
//
//          GetInstanceAgentPluginsFilterArgs{...}
type GetInstanceAgentPluginsFilterInput interface {
	pulumi.Input

	ToGetInstanceAgentPluginsFilterOutput() GetInstanceAgentPluginsFilterOutput
	ToGetInstanceAgentPluginsFilterOutputWithContext(context.Context) GetInstanceAgentPluginsFilterOutput
}

type GetInstanceAgentPluginsFilterArgs struct {
	// The plugin name
	Name   pulumi.StringInput      `pulumi:"name"`
	Regex  pulumi.BoolPtrInput     `pulumi:"regex"`
	Values pulumi.StringArrayInput `pulumi:"values"`
}

func (GetInstanceAgentPluginsFilterArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetInstanceAgentPluginsFilter)(nil)).Elem()
}

func (i GetInstanceAgentPluginsFilterArgs) ToGetInstanceAgentPluginsFilterOutput() GetInstanceAgentPluginsFilterOutput {
	return i.ToGetInstanceAgentPluginsFilterOutputWithContext(context.Background())
}

func (i GetInstanceAgentPluginsFilterArgs) ToGetInstanceAgentPluginsFilterOutputWithContext(ctx context.Context) GetInstanceAgentPluginsFilterOutput {
	return pulumi.ToOutputWithContext(ctx, i).(GetInstanceAgentPluginsFilterOutput)
}

// GetInstanceAgentPluginsFilterArrayInput is an input type that accepts GetInstanceAgentPluginsFilterArray and GetInstanceAgentPluginsFilterArrayOutput values.
// You can construct a concrete instance of `GetInstanceAgentPluginsFilterArrayInput` via:
//
//          GetInstanceAgentPluginsFilterArray{ GetInstanceAgentPluginsFilterArgs{...} }
type GetInstanceAgentPluginsFilterArrayInput interface {
	pulumi.Input

	ToGetInstanceAgentPluginsFilterArrayOutput() GetInstanceAgentPluginsFilterArrayOutput
	ToGetInstanceAgentPluginsFilterArrayOutputWithContext(context.Context) GetInstanceAgentPluginsFilterArrayOutput
}

type GetInstanceAgentPluginsFilterArray []GetInstanceAgentPluginsFilterInput

func (GetInstanceAgentPluginsFilterArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]GetInstanceAgentPluginsFilter)(nil)).Elem()
}

func (i GetInstanceAgentPluginsFilterArray) ToGetInstanceAgentPluginsFilterArrayOutput() GetInstanceAgentPluginsFilterArrayOutput {
	return i.ToGetInstanceAgentPluginsFilterArrayOutputWithContext(context.Background())
}

func (i GetInstanceAgentPluginsFilterArray) ToGetInstanceAgentPluginsFilterArrayOutputWithContext(ctx context.Context) GetInstanceAgentPluginsFilterArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(GetInstanceAgentPluginsFilterArrayOutput)
}

type GetInstanceAgentPluginsFilterOutput struct{ *pulumi.OutputState }

func (GetInstanceAgentPluginsFilterOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetInstanceAgentPluginsFilter)(nil)).Elem()
}

func (o GetInstanceAgentPluginsFilterOutput) ToGetInstanceAgentPluginsFilterOutput() GetInstanceAgentPluginsFilterOutput {
	return o
}

func (o GetInstanceAgentPluginsFilterOutput) ToGetInstanceAgentPluginsFilterOutputWithContext(ctx context.Context) GetInstanceAgentPluginsFilterOutput {
	return o
}

// The plugin name
func (o GetInstanceAgentPluginsFilterOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v GetInstanceAgentPluginsFilter) string { return v.Name }).(pulumi.StringOutput)
}

func (o GetInstanceAgentPluginsFilterOutput) Regex() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v GetInstanceAgentPluginsFilter) *bool { return v.Regex }).(pulumi.BoolPtrOutput)
}

func (o GetInstanceAgentPluginsFilterOutput) Values() pulumi.StringArrayOutput {
	return o.ApplyT(func(v GetInstanceAgentPluginsFilter) []string { return v.Values }).(pulumi.StringArrayOutput)
}

type GetInstanceAgentPluginsFilterArrayOutput struct{ *pulumi.OutputState }

func (GetInstanceAgentPluginsFilterArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]GetInstanceAgentPluginsFilter)(nil)).Elem()
}

func (o GetInstanceAgentPluginsFilterArrayOutput) ToGetInstanceAgentPluginsFilterArrayOutput() GetInstanceAgentPluginsFilterArrayOutput {
	return o
}

func (o GetInstanceAgentPluginsFilterArrayOutput) ToGetInstanceAgentPluginsFilterArrayOutputWithContext(ctx context.Context) GetInstanceAgentPluginsFilterArrayOutput {
	return o
}

func (o GetInstanceAgentPluginsFilterArrayOutput) Index(i pulumi.IntInput) GetInstanceAgentPluginsFilterOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) GetInstanceAgentPluginsFilter {
		return vs[0].([]GetInstanceAgentPluginsFilter)[vs[1].(int)]
	}).(GetInstanceAgentPluginsFilterOutput)
}

type GetInstanceAgentPluginsInstanceAgentPlugin struct {
	// The optional message from the agent plugin
	Message string `pulumi:"message"`
	// The plugin name
	Name string `pulumi:"name"`
	// The plugin status
	Status string `pulumi:"status"`
	// The last update time of the plugin in UTC
	TimeLastUpdatedUtc string `pulumi:"timeLastUpdatedUtc"`
}

// GetInstanceAgentPluginsInstanceAgentPluginInput is an input type that accepts GetInstanceAgentPluginsInstanceAgentPluginArgs and GetInstanceAgentPluginsInstanceAgentPluginOutput values.
// You can construct a concrete instance of `GetInstanceAgentPluginsInstanceAgentPluginInput` via:
//
//          GetInstanceAgentPluginsInstanceAgentPluginArgs{...}
type GetInstanceAgentPluginsInstanceAgentPluginInput interface {
	pulumi.Input

	ToGetInstanceAgentPluginsInstanceAgentPluginOutput() GetInstanceAgentPluginsInstanceAgentPluginOutput
	ToGetInstanceAgentPluginsInstanceAgentPluginOutputWithContext(context.Context) GetInstanceAgentPluginsInstanceAgentPluginOutput
}

type GetInstanceAgentPluginsInstanceAgentPluginArgs struct {
	// The optional message from the agent plugin
	Message pulumi.StringInput `pulumi:"message"`
	// The plugin name
	Name pulumi.StringInput `pulumi:"name"`
	// The plugin status
	Status pulumi.StringInput `pulumi:"status"`
	// The last update time of the plugin in UTC
	TimeLastUpdatedUtc pulumi.StringInput `pulumi:"timeLastUpdatedUtc"`
}

func (GetInstanceAgentPluginsInstanceAgentPluginArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetInstanceAgentPluginsInstanceAgentPlugin)(nil)).Elem()
}

func (i GetInstanceAgentPluginsInstanceAgentPluginArgs) ToGetInstanceAgentPluginsInstanceAgentPluginOutput() GetInstanceAgentPluginsInstanceAgentPluginOutput {
	return i.ToGetInstanceAgentPluginsInstanceAgentPluginOutputWithContext(context.Background())
}

func (i GetInstanceAgentPluginsInstanceAgentPluginArgs) ToGetInstanceAgentPluginsInstanceAgentPluginOutputWithContext(ctx context.Context) GetInstanceAgentPluginsInstanceAgentPluginOutput {
	return pulumi.ToOutputWithContext(ctx, i).(GetInstanceAgentPluginsInstanceAgentPluginOutput)
}

// GetInstanceAgentPluginsInstanceAgentPluginArrayInput is an input type that accepts GetInstanceAgentPluginsInstanceAgentPluginArray and GetInstanceAgentPluginsInstanceAgentPluginArrayOutput values.
// You can construct a concrete instance of `GetInstanceAgentPluginsInstanceAgentPluginArrayInput` via:
//
//          GetInstanceAgentPluginsInstanceAgentPluginArray{ GetInstanceAgentPluginsInstanceAgentPluginArgs{...} }
type GetInstanceAgentPluginsInstanceAgentPluginArrayInput interface {
	pulumi.Input

	ToGetInstanceAgentPluginsInstanceAgentPluginArrayOutput() GetInstanceAgentPluginsInstanceAgentPluginArrayOutput
	ToGetInstanceAgentPluginsInstanceAgentPluginArrayOutputWithContext(context.Context) GetInstanceAgentPluginsInstanceAgentPluginArrayOutput
}

type GetInstanceAgentPluginsInstanceAgentPluginArray []GetInstanceAgentPluginsInstanceAgentPluginInput

func (GetInstanceAgentPluginsInstanceAgentPluginArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]GetInstanceAgentPluginsInstanceAgentPlugin)(nil)).Elem()
}

func (i GetInstanceAgentPluginsInstanceAgentPluginArray) ToGetInstanceAgentPluginsInstanceAgentPluginArrayOutput() GetInstanceAgentPluginsInstanceAgentPluginArrayOutput {
	return i.ToGetInstanceAgentPluginsInstanceAgentPluginArrayOutputWithContext(context.Background())
}

func (i GetInstanceAgentPluginsInstanceAgentPluginArray) ToGetInstanceAgentPluginsInstanceAgentPluginArrayOutputWithContext(ctx context.Context) GetInstanceAgentPluginsInstanceAgentPluginArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(GetInstanceAgentPluginsInstanceAgentPluginArrayOutput)
}

type GetInstanceAgentPluginsInstanceAgentPluginOutput struct{ *pulumi.OutputState }

func (GetInstanceAgentPluginsInstanceAgentPluginOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetInstanceAgentPluginsInstanceAgentPlugin)(nil)).Elem()
}

func (o GetInstanceAgentPluginsInstanceAgentPluginOutput) ToGetInstanceAgentPluginsInstanceAgentPluginOutput() GetInstanceAgentPluginsInstanceAgentPluginOutput {
	return o
}

func (o GetInstanceAgentPluginsInstanceAgentPluginOutput) ToGetInstanceAgentPluginsInstanceAgentPluginOutputWithContext(ctx context.Context) GetInstanceAgentPluginsInstanceAgentPluginOutput {
	return o
}

// The optional message from the agent plugin
func (o GetInstanceAgentPluginsInstanceAgentPluginOutput) Message() pulumi.StringOutput {
	return o.ApplyT(func(v GetInstanceAgentPluginsInstanceAgentPlugin) string { return v.Message }).(pulumi.StringOutput)
}

// The plugin name
func (o GetInstanceAgentPluginsInstanceAgentPluginOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v GetInstanceAgentPluginsInstanceAgentPlugin) string { return v.Name }).(pulumi.StringOutput)
}

// The plugin status
func (o GetInstanceAgentPluginsInstanceAgentPluginOutput) Status() pulumi.StringOutput {
	return o.ApplyT(func(v GetInstanceAgentPluginsInstanceAgentPlugin) string { return v.Status }).(pulumi.StringOutput)
}

// The last update time of the plugin in UTC
func (o GetInstanceAgentPluginsInstanceAgentPluginOutput) TimeLastUpdatedUtc() pulumi.StringOutput {
	return o.ApplyT(func(v GetInstanceAgentPluginsInstanceAgentPlugin) string { return v.TimeLastUpdatedUtc }).(pulumi.StringOutput)
}

type GetInstanceAgentPluginsInstanceAgentPluginArrayOutput struct{ *pulumi.OutputState }

func (GetInstanceAgentPluginsInstanceAgentPluginArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]GetInstanceAgentPluginsInstanceAgentPlugin)(nil)).Elem()
}

func (o GetInstanceAgentPluginsInstanceAgentPluginArrayOutput) ToGetInstanceAgentPluginsInstanceAgentPluginArrayOutput() GetInstanceAgentPluginsInstanceAgentPluginArrayOutput {
	return o
}

func (o GetInstanceAgentPluginsInstanceAgentPluginArrayOutput) ToGetInstanceAgentPluginsInstanceAgentPluginArrayOutputWithContext(ctx context.Context) GetInstanceAgentPluginsInstanceAgentPluginArrayOutput {
	return o
}

func (o GetInstanceAgentPluginsInstanceAgentPluginArrayOutput) Index(i pulumi.IntInput) GetInstanceAgentPluginsInstanceAgentPluginOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) GetInstanceAgentPluginsInstanceAgentPlugin {
		return vs[0].([]GetInstanceAgentPluginsInstanceAgentPlugin)[vs[1].(int)]
	}).(GetInstanceAgentPluginsInstanceAgentPluginOutput)
}

type GetInstanceAvailablePluginsAvailablePlugin struct {
	// Is the plugin enabled or disabled by default
	IsEnabledByDefault bool `pulumi:"isEnabledByDefault"`
	// Is the plugin supported or not
	IsSupported bool `pulumi:"isSupported"`
	// The plugin name
	Name string `pulumi:"name"`
	// A brief description of the plugin functionality
	Summary string `pulumi:"summary"`
}

// GetInstanceAvailablePluginsAvailablePluginInput is an input type that accepts GetInstanceAvailablePluginsAvailablePluginArgs and GetInstanceAvailablePluginsAvailablePluginOutput values.
// You can construct a concrete instance of `GetInstanceAvailablePluginsAvailablePluginInput` via:
//
//          GetInstanceAvailablePluginsAvailablePluginArgs{...}
type GetInstanceAvailablePluginsAvailablePluginInput interface {
	pulumi.Input

	ToGetInstanceAvailablePluginsAvailablePluginOutput() GetInstanceAvailablePluginsAvailablePluginOutput
	ToGetInstanceAvailablePluginsAvailablePluginOutputWithContext(context.Context) GetInstanceAvailablePluginsAvailablePluginOutput
}

type GetInstanceAvailablePluginsAvailablePluginArgs struct {
	// Is the plugin enabled or disabled by default
	IsEnabledByDefault pulumi.BoolInput `pulumi:"isEnabledByDefault"`
	// Is the plugin supported or not
	IsSupported pulumi.BoolInput `pulumi:"isSupported"`
	// The plugin name
	Name pulumi.StringInput `pulumi:"name"`
	// A brief description of the plugin functionality
	Summary pulumi.StringInput `pulumi:"summary"`
}

func (GetInstanceAvailablePluginsAvailablePluginArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetInstanceAvailablePluginsAvailablePlugin)(nil)).Elem()
}

func (i GetInstanceAvailablePluginsAvailablePluginArgs) ToGetInstanceAvailablePluginsAvailablePluginOutput() GetInstanceAvailablePluginsAvailablePluginOutput {
	return i.ToGetInstanceAvailablePluginsAvailablePluginOutputWithContext(context.Background())
}

func (i GetInstanceAvailablePluginsAvailablePluginArgs) ToGetInstanceAvailablePluginsAvailablePluginOutputWithContext(ctx context.Context) GetInstanceAvailablePluginsAvailablePluginOutput {
	return pulumi.ToOutputWithContext(ctx, i).(GetInstanceAvailablePluginsAvailablePluginOutput)
}

// GetInstanceAvailablePluginsAvailablePluginArrayInput is an input type that accepts GetInstanceAvailablePluginsAvailablePluginArray and GetInstanceAvailablePluginsAvailablePluginArrayOutput values.
// You can construct a concrete instance of `GetInstanceAvailablePluginsAvailablePluginArrayInput` via:
//
//          GetInstanceAvailablePluginsAvailablePluginArray{ GetInstanceAvailablePluginsAvailablePluginArgs{...} }
type GetInstanceAvailablePluginsAvailablePluginArrayInput interface {
	pulumi.Input

	ToGetInstanceAvailablePluginsAvailablePluginArrayOutput() GetInstanceAvailablePluginsAvailablePluginArrayOutput
	ToGetInstanceAvailablePluginsAvailablePluginArrayOutputWithContext(context.Context) GetInstanceAvailablePluginsAvailablePluginArrayOutput
}

type GetInstanceAvailablePluginsAvailablePluginArray []GetInstanceAvailablePluginsAvailablePluginInput

func (GetInstanceAvailablePluginsAvailablePluginArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]GetInstanceAvailablePluginsAvailablePlugin)(nil)).Elem()
}

func (i GetInstanceAvailablePluginsAvailablePluginArray) ToGetInstanceAvailablePluginsAvailablePluginArrayOutput() GetInstanceAvailablePluginsAvailablePluginArrayOutput {
	return i.ToGetInstanceAvailablePluginsAvailablePluginArrayOutputWithContext(context.Background())
}

func (i GetInstanceAvailablePluginsAvailablePluginArray) ToGetInstanceAvailablePluginsAvailablePluginArrayOutputWithContext(ctx context.Context) GetInstanceAvailablePluginsAvailablePluginArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(GetInstanceAvailablePluginsAvailablePluginArrayOutput)
}

type GetInstanceAvailablePluginsAvailablePluginOutput struct{ *pulumi.OutputState }

func (GetInstanceAvailablePluginsAvailablePluginOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetInstanceAvailablePluginsAvailablePlugin)(nil)).Elem()
}

func (o GetInstanceAvailablePluginsAvailablePluginOutput) ToGetInstanceAvailablePluginsAvailablePluginOutput() GetInstanceAvailablePluginsAvailablePluginOutput {
	return o
}

func (o GetInstanceAvailablePluginsAvailablePluginOutput) ToGetInstanceAvailablePluginsAvailablePluginOutputWithContext(ctx context.Context) GetInstanceAvailablePluginsAvailablePluginOutput {
	return o
}

// Is the plugin enabled or disabled by default
func (o GetInstanceAvailablePluginsAvailablePluginOutput) IsEnabledByDefault() pulumi.BoolOutput {
	return o.ApplyT(func(v GetInstanceAvailablePluginsAvailablePlugin) bool { return v.IsEnabledByDefault }).(pulumi.BoolOutput)
}

// Is the plugin supported or not
func (o GetInstanceAvailablePluginsAvailablePluginOutput) IsSupported() pulumi.BoolOutput {
	return o.ApplyT(func(v GetInstanceAvailablePluginsAvailablePlugin) bool { return v.IsSupported }).(pulumi.BoolOutput)
}

// The plugin name
func (o GetInstanceAvailablePluginsAvailablePluginOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v GetInstanceAvailablePluginsAvailablePlugin) string { return v.Name }).(pulumi.StringOutput)
}

// A brief description of the plugin functionality
func (o GetInstanceAvailablePluginsAvailablePluginOutput) Summary() pulumi.StringOutput {
	return o.ApplyT(func(v GetInstanceAvailablePluginsAvailablePlugin) string { return v.Summary }).(pulumi.StringOutput)
}

type GetInstanceAvailablePluginsAvailablePluginArrayOutput struct{ *pulumi.OutputState }

func (GetInstanceAvailablePluginsAvailablePluginArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]GetInstanceAvailablePluginsAvailablePlugin)(nil)).Elem()
}

func (o GetInstanceAvailablePluginsAvailablePluginArrayOutput) ToGetInstanceAvailablePluginsAvailablePluginArrayOutput() GetInstanceAvailablePluginsAvailablePluginArrayOutput {
	return o
}

func (o GetInstanceAvailablePluginsAvailablePluginArrayOutput) ToGetInstanceAvailablePluginsAvailablePluginArrayOutputWithContext(ctx context.Context) GetInstanceAvailablePluginsAvailablePluginArrayOutput {
	return o
}

func (o GetInstanceAvailablePluginsAvailablePluginArrayOutput) Index(i pulumi.IntInput) GetInstanceAvailablePluginsAvailablePluginOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) GetInstanceAvailablePluginsAvailablePlugin {
		return vs[0].([]GetInstanceAvailablePluginsAvailablePlugin)[vs[1].(int)]
	}).(GetInstanceAvailablePluginsAvailablePluginOutput)
}

type GetInstanceAvailablePluginsFilter struct {
	// The plugin name
	Name   string   `pulumi:"name"`
	Regex  *bool    `pulumi:"regex"`
	Values []string `pulumi:"values"`
}

// GetInstanceAvailablePluginsFilterInput is an input type that accepts GetInstanceAvailablePluginsFilterArgs and GetInstanceAvailablePluginsFilterOutput values.
// You can construct a concrete instance of `GetInstanceAvailablePluginsFilterInput` via:
//
//          GetInstanceAvailablePluginsFilterArgs{...}
type GetInstanceAvailablePluginsFilterInput interface {
	pulumi.Input

	ToGetInstanceAvailablePluginsFilterOutput() GetInstanceAvailablePluginsFilterOutput
	ToGetInstanceAvailablePluginsFilterOutputWithContext(context.Context) GetInstanceAvailablePluginsFilterOutput
}

type GetInstanceAvailablePluginsFilterArgs struct {
	// The plugin name
	Name   pulumi.StringInput      `pulumi:"name"`
	Regex  pulumi.BoolPtrInput     `pulumi:"regex"`
	Values pulumi.StringArrayInput `pulumi:"values"`
}

func (GetInstanceAvailablePluginsFilterArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetInstanceAvailablePluginsFilter)(nil)).Elem()
}

func (i GetInstanceAvailablePluginsFilterArgs) ToGetInstanceAvailablePluginsFilterOutput() GetInstanceAvailablePluginsFilterOutput {
	return i.ToGetInstanceAvailablePluginsFilterOutputWithContext(context.Background())
}

func (i GetInstanceAvailablePluginsFilterArgs) ToGetInstanceAvailablePluginsFilterOutputWithContext(ctx context.Context) GetInstanceAvailablePluginsFilterOutput {
	return pulumi.ToOutputWithContext(ctx, i).(GetInstanceAvailablePluginsFilterOutput)
}

// GetInstanceAvailablePluginsFilterArrayInput is an input type that accepts GetInstanceAvailablePluginsFilterArray and GetInstanceAvailablePluginsFilterArrayOutput values.
// You can construct a concrete instance of `GetInstanceAvailablePluginsFilterArrayInput` via:
//
//          GetInstanceAvailablePluginsFilterArray{ GetInstanceAvailablePluginsFilterArgs{...} }
type GetInstanceAvailablePluginsFilterArrayInput interface {
	pulumi.Input

	ToGetInstanceAvailablePluginsFilterArrayOutput() GetInstanceAvailablePluginsFilterArrayOutput
	ToGetInstanceAvailablePluginsFilterArrayOutputWithContext(context.Context) GetInstanceAvailablePluginsFilterArrayOutput
}

type GetInstanceAvailablePluginsFilterArray []GetInstanceAvailablePluginsFilterInput

func (GetInstanceAvailablePluginsFilterArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]GetInstanceAvailablePluginsFilter)(nil)).Elem()
}

func (i GetInstanceAvailablePluginsFilterArray) ToGetInstanceAvailablePluginsFilterArrayOutput() GetInstanceAvailablePluginsFilterArrayOutput {
	return i.ToGetInstanceAvailablePluginsFilterArrayOutputWithContext(context.Background())
}

func (i GetInstanceAvailablePluginsFilterArray) ToGetInstanceAvailablePluginsFilterArrayOutputWithContext(ctx context.Context) GetInstanceAvailablePluginsFilterArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(GetInstanceAvailablePluginsFilterArrayOutput)
}

type GetInstanceAvailablePluginsFilterOutput struct{ *pulumi.OutputState }

func (GetInstanceAvailablePluginsFilterOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetInstanceAvailablePluginsFilter)(nil)).Elem()
}

func (o GetInstanceAvailablePluginsFilterOutput) ToGetInstanceAvailablePluginsFilterOutput() GetInstanceAvailablePluginsFilterOutput {
	return o
}

func (o GetInstanceAvailablePluginsFilterOutput) ToGetInstanceAvailablePluginsFilterOutputWithContext(ctx context.Context) GetInstanceAvailablePluginsFilterOutput {
	return o
}

// The plugin name
func (o GetInstanceAvailablePluginsFilterOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v GetInstanceAvailablePluginsFilter) string { return v.Name }).(pulumi.StringOutput)
}

func (o GetInstanceAvailablePluginsFilterOutput) Regex() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v GetInstanceAvailablePluginsFilter) *bool { return v.Regex }).(pulumi.BoolPtrOutput)
}

func (o GetInstanceAvailablePluginsFilterOutput) Values() pulumi.StringArrayOutput {
	return o.ApplyT(func(v GetInstanceAvailablePluginsFilter) []string { return v.Values }).(pulumi.StringArrayOutput)
}

type GetInstanceAvailablePluginsFilterArrayOutput struct{ *pulumi.OutputState }

func (GetInstanceAvailablePluginsFilterArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]GetInstanceAvailablePluginsFilter)(nil)).Elem()
}

func (o GetInstanceAvailablePluginsFilterArrayOutput) ToGetInstanceAvailablePluginsFilterArrayOutput() GetInstanceAvailablePluginsFilterArrayOutput {
	return o
}

func (o GetInstanceAvailablePluginsFilterArrayOutput) ToGetInstanceAvailablePluginsFilterArrayOutputWithContext(ctx context.Context) GetInstanceAvailablePluginsFilterArrayOutput {
	return o
}

func (o GetInstanceAvailablePluginsFilterArrayOutput) Index(i pulumi.IntInput) GetInstanceAvailablePluginsFilterOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) GetInstanceAvailablePluginsFilter {
		return vs[0].([]GetInstanceAvailablePluginsFilter)[vs[1].(int)]
	}).(GetInstanceAvailablePluginsFilterOutput)
}

func init() {
	pulumi.RegisterOutputType(GetInstanceAgentPluginsFilterOutput{})
	pulumi.RegisterOutputType(GetInstanceAgentPluginsFilterArrayOutput{})
	pulumi.RegisterOutputType(GetInstanceAgentPluginsInstanceAgentPluginOutput{})
	pulumi.RegisterOutputType(GetInstanceAgentPluginsInstanceAgentPluginArrayOutput{})
	pulumi.RegisterOutputType(GetInstanceAvailablePluginsAvailablePluginOutput{})
	pulumi.RegisterOutputType(GetInstanceAvailablePluginsAvailablePluginArrayOutput{})
	pulumi.RegisterOutputType(GetInstanceAvailablePluginsFilterOutput{})
	pulumi.RegisterOutputType(GetInstanceAvailablePluginsFilterArrayOutput{})
}