// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: review.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace VND.CoolStore.Services.Review.v1.Grpc {
  public static partial class PingService
  {
    static readonly string __ServiceName = "review.PingService";

    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::VND.CoolStore.Services.Review.v1.Grpc.PingResponse> __Marshaller_review_PingResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::VND.CoolStore.Services.Review.v1.Grpc.PingResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::VND.CoolStore.Services.Review.v1.Grpc.PingResponse> __Method_Ping = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::VND.CoolStore.Services.Review.v1.Grpc.PingResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Ping",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_review_PingResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::VND.CoolStore.Services.Review.v1.Grpc.ReviewReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of PingService</summary>
    public abstract partial class PingServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::VND.CoolStore.Services.Review.v1.Grpc.PingResponse> Ping(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for PingService</summary>
    public partial class PingServiceClient : grpc::ClientBase<PingServiceClient>
    {
      /// <summary>Creates a new client for PingService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public PingServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for PingService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public PingServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected PingServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected PingServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::VND.CoolStore.Services.Review.v1.Grpc.PingResponse Ping(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Ping(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::VND.CoolStore.Services.Review.v1.Grpc.PingResponse Ping(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Ping, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::VND.CoolStore.Services.Review.v1.Grpc.PingResponse> PingAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return PingAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::VND.CoolStore.Services.Review.v1.Grpc.PingResponse> PingAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Ping, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override PingServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new PingServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(PingServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Ping, serviceImpl.Ping).Build();
    }

    /// <summary>Register service method implementations with a service binder. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, PingServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Ping, serviceImpl.Ping);
    }

  }
  public static partial class ReviewService
  {
    static readonly string __ServiceName = "review.ReviewService";

    static readonly grpc::Marshaller<global::VND.CoolStore.Services.Review.v1.Grpc.GetReviewsRequest> __Marshaller_review_GetReviewsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::VND.CoolStore.Services.Review.v1.Grpc.GetReviewsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::VND.CoolStore.Services.Review.v1.Grpc.GetReviewsResponse> __Marshaller_review_GetReviewsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::VND.CoolStore.Services.Review.v1.Grpc.GetReviewsResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::VND.CoolStore.Services.Review.v1.Grpc.CreateReviewRequest> __Marshaller_review_CreateReviewRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::VND.CoolStore.Services.Review.v1.Grpc.CreateReviewRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::VND.CoolStore.Services.Review.v1.Grpc.CreateReviewResponse> __Marshaller_review_CreateReviewResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::VND.CoolStore.Services.Review.v1.Grpc.CreateReviewResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::VND.CoolStore.Services.Review.v1.Grpc.EditReviewRequest> __Marshaller_review_EditReviewRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::VND.CoolStore.Services.Review.v1.Grpc.EditReviewRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::VND.CoolStore.Services.Review.v1.Grpc.EditReviewResponse> __Marshaller_review_EditReviewResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::VND.CoolStore.Services.Review.v1.Grpc.EditReviewResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::VND.CoolStore.Services.Review.v1.Grpc.DeleteReviewRequest> __Marshaller_review_DeleteReviewRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::VND.CoolStore.Services.Review.v1.Grpc.DeleteReviewRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::VND.CoolStore.Services.Review.v1.Grpc.DeleteReviewResponse> __Marshaller_review_DeleteReviewResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::VND.CoolStore.Services.Review.v1.Grpc.DeleteReviewResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::VND.CoolStore.Services.Review.v1.Grpc.GetReviewsRequest, global::VND.CoolStore.Services.Review.v1.Grpc.GetReviewsResponse> __Method_GetReviews = new grpc::Method<global::VND.CoolStore.Services.Review.v1.Grpc.GetReviewsRequest, global::VND.CoolStore.Services.Review.v1.Grpc.GetReviewsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetReviews",
        __Marshaller_review_GetReviewsRequest,
        __Marshaller_review_GetReviewsResponse);

    static readonly grpc::Method<global::VND.CoolStore.Services.Review.v1.Grpc.CreateReviewRequest, global::VND.CoolStore.Services.Review.v1.Grpc.CreateReviewResponse> __Method_CreateReview = new grpc::Method<global::VND.CoolStore.Services.Review.v1.Grpc.CreateReviewRequest, global::VND.CoolStore.Services.Review.v1.Grpc.CreateReviewResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateReview",
        __Marshaller_review_CreateReviewRequest,
        __Marshaller_review_CreateReviewResponse);

    static readonly grpc::Method<global::VND.CoolStore.Services.Review.v1.Grpc.EditReviewRequest, global::VND.CoolStore.Services.Review.v1.Grpc.EditReviewResponse> __Method_EditReview = new grpc::Method<global::VND.CoolStore.Services.Review.v1.Grpc.EditReviewRequest, global::VND.CoolStore.Services.Review.v1.Grpc.EditReviewResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "EditReview",
        __Marshaller_review_EditReviewRequest,
        __Marshaller_review_EditReviewResponse);

    static readonly grpc::Method<global::VND.CoolStore.Services.Review.v1.Grpc.DeleteReviewRequest, global::VND.CoolStore.Services.Review.v1.Grpc.DeleteReviewResponse> __Method_DeleteReview = new grpc::Method<global::VND.CoolStore.Services.Review.v1.Grpc.DeleteReviewRequest, global::VND.CoolStore.Services.Review.v1.Grpc.DeleteReviewResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteReview",
        __Marshaller_review_DeleteReviewRequest,
        __Marshaller_review_DeleteReviewResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::VND.CoolStore.Services.Review.v1.Grpc.ReviewReflection.Descriptor.Services[1]; }
    }

    /// <summary>Base class for server-side implementations of ReviewService</summary>
    public abstract partial class ReviewServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::VND.CoolStore.Services.Review.v1.Grpc.GetReviewsResponse> GetReviews(global::VND.CoolStore.Services.Review.v1.Grpc.GetReviewsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::VND.CoolStore.Services.Review.v1.Grpc.CreateReviewResponse> CreateReview(global::VND.CoolStore.Services.Review.v1.Grpc.CreateReviewRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::VND.CoolStore.Services.Review.v1.Grpc.EditReviewResponse> EditReview(global::VND.CoolStore.Services.Review.v1.Grpc.EditReviewRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::VND.CoolStore.Services.Review.v1.Grpc.DeleteReviewResponse> DeleteReview(global::VND.CoolStore.Services.Review.v1.Grpc.DeleteReviewRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for ReviewService</summary>
    public partial class ReviewServiceClient : grpc::ClientBase<ReviewServiceClient>
    {
      /// <summary>Creates a new client for ReviewService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ReviewServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ReviewService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ReviewServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ReviewServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ReviewServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::VND.CoolStore.Services.Review.v1.Grpc.GetReviewsResponse GetReviews(global::VND.CoolStore.Services.Review.v1.Grpc.GetReviewsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetReviews(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::VND.CoolStore.Services.Review.v1.Grpc.GetReviewsResponse GetReviews(global::VND.CoolStore.Services.Review.v1.Grpc.GetReviewsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetReviews, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::VND.CoolStore.Services.Review.v1.Grpc.GetReviewsResponse> GetReviewsAsync(global::VND.CoolStore.Services.Review.v1.Grpc.GetReviewsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetReviewsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::VND.CoolStore.Services.Review.v1.Grpc.GetReviewsResponse> GetReviewsAsync(global::VND.CoolStore.Services.Review.v1.Grpc.GetReviewsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetReviews, null, options, request);
      }
      public virtual global::VND.CoolStore.Services.Review.v1.Grpc.CreateReviewResponse CreateReview(global::VND.CoolStore.Services.Review.v1.Grpc.CreateReviewRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateReview(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::VND.CoolStore.Services.Review.v1.Grpc.CreateReviewResponse CreateReview(global::VND.CoolStore.Services.Review.v1.Grpc.CreateReviewRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateReview, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::VND.CoolStore.Services.Review.v1.Grpc.CreateReviewResponse> CreateReviewAsync(global::VND.CoolStore.Services.Review.v1.Grpc.CreateReviewRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateReviewAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::VND.CoolStore.Services.Review.v1.Grpc.CreateReviewResponse> CreateReviewAsync(global::VND.CoolStore.Services.Review.v1.Grpc.CreateReviewRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateReview, null, options, request);
      }
      public virtual global::VND.CoolStore.Services.Review.v1.Grpc.EditReviewResponse EditReview(global::VND.CoolStore.Services.Review.v1.Grpc.EditReviewRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return EditReview(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::VND.CoolStore.Services.Review.v1.Grpc.EditReviewResponse EditReview(global::VND.CoolStore.Services.Review.v1.Grpc.EditReviewRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_EditReview, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::VND.CoolStore.Services.Review.v1.Grpc.EditReviewResponse> EditReviewAsync(global::VND.CoolStore.Services.Review.v1.Grpc.EditReviewRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return EditReviewAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::VND.CoolStore.Services.Review.v1.Grpc.EditReviewResponse> EditReviewAsync(global::VND.CoolStore.Services.Review.v1.Grpc.EditReviewRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_EditReview, null, options, request);
      }
      public virtual global::VND.CoolStore.Services.Review.v1.Grpc.DeleteReviewResponse DeleteReview(global::VND.CoolStore.Services.Review.v1.Grpc.DeleteReviewRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteReview(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::VND.CoolStore.Services.Review.v1.Grpc.DeleteReviewResponse DeleteReview(global::VND.CoolStore.Services.Review.v1.Grpc.DeleteReviewRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteReview, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::VND.CoolStore.Services.Review.v1.Grpc.DeleteReviewResponse> DeleteReviewAsync(global::VND.CoolStore.Services.Review.v1.Grpc.DeleteReviewRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteReviewAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::VND.CoolStore.Services.Review.v1.Grpc.DeleteReviewResponse> DeleteReviewAsync(global::VND.CoolStore.Services.Review.v1.Grpc.DeleteReviewRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteReview, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override ReviewServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ReviewServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(ReviewServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetReviews, serviceImpl.GetReviews)
          .AddMethod(__Method_CreateReview, serviceImpl.CreateReview)
          .AddMethod(__Method_EditReview, serviceImpl.EditReview)
          .AddMethod(__Method_DeleteReview, serviceImpl.DeleteReview).Build();
    }

    /// <summary>Register service method implementations with a service binder. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ReviewServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetReviews, serviceImpl.GetReviews);
      serviceBinder.AddMethod(__Method_CreateReview, serviceImpl.CreateReview);
      serviceBinder.AddMethod(__Method_EditReview, serviceImpl.EditReview);
      serviceBinder.AddMethod(__Method_DeleteReview, serviceImpl.DeleteReview);
    }

  }
}
#endregion
