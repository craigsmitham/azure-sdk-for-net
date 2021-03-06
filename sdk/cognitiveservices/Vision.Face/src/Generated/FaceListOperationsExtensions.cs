// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Vision.Face
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for FaceListOperations.
    /// </summary>
    public static partial class FaceListOperationsExtensions
    {
            /// <summary>
            /// Create an empty face list with user-specified faceListId, name, an optional
            /// userData and recognitionModel. Up to 64 face lists are allowed in one
            /// subscription.
            /// &lt;br /&gt; Face list is a list of faces, up to 1,000 faces, and used by
            /// [Face - Find
            /// Similar](/docs/services/563879b61984550e40cbbe8d/operations/563879b61984550f30395237).
            /// &lt;br /&gt; After creation, user should use [FaceList - Add
            /// Face](/docs/services/563879b61984550e40cbbe8d/operations/563879b61984550f30395250)
            /// to import the faces. No image will be stored. Only the extracted face
            /// features are stored on server until [FaceList -
            /// Delete](/docs/services/563879b61984550e40cbbe8d/operations/563879b61984550f3039524f)
            /// is called.
            /// &lt;br /&gt; Find Similar is used for scenario like finding celebrity-like
            /// faces, similar face filtering, or as a light way face identification. But
            /// if the actual use is to identify person, please use
            /// [PersonGroup](/docs/services/563879b61984550e40cbbe8d/operations/563879b61984550f30395244)
            /// /
            /// [LargePersonGroup](/docs/services/563879b61984550e40cbbe8d/operations/599acdee6ac60f11b48b5a9d)
            /// and [Face -
            /// Identify](/docs/services/563879b61984550e40cbbe8d/operations/563879b61984550f30395239).
            /// &lt;br /&gt; Please consider
            /// [LargeFaceList](/docs/services/563879b61984550e40cbbe8d/operations/5a157b68d2de3616c086f2cc)
            /// when the face number is large. It can support up to 1,000,000 faces.
            /// &lt;br /&gt;'recognitionModel' should be specified to associate with this
            /// face list. The default value for 'recognitionModel' is 'recognition_01', if
            /// the latest model needed, please explicitly specify the model you need in
            /// this parameter. New faces that are added to an existing face list will use
            /// the recognition model that's already associated with the collection.
            /// Existing face features in a face list can't be updated to features
            /// extracted by another version of recognition model.
            /// * 'recognition_01': The default recognition model for [FaceList-
            /// Create](/docs/services/563879b61984550e40cbbe8d/operations/563879b61984550f3039524b).
            /// All those face lists created before 2019 March are bonded with this
            /// recognition model.
            /// * 'recognition_02': Recognition model released in 2019 March.
            /// 'recognition_02' is recommended since its overall accuracy is improved
            /// compared with 'recognition_01'.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='faceListId'>
            /// Id referencing a particular face list.
            /// </param>
            /// <param name='name'>
            /// User defined name, maximum length is 128.
            /// </param>
            /// <param name='userData'>
            /// User specified data. Length should not exceed 16KB.
            /// </param>
            /// <param name='recognitionModel'>
            /// Possible values include: 'recognition_01', 'recognition_02'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task CreateAsync(this IFaceListOperations operations, string faceListId, string name = default(string), string userData = default(string), string recognitionModel = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.CreateWithHttpMessagesAsync(faceListId, name, userData, recognitionModel, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Retrieve a face list’s faceListId, name, userData, recognitionModel and
            /// faces in the face list.
            ///
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='faceListId'>
            /// Id referencing a particular face list.
            /// </param>
            /// <param name='returnRecognitionModel'>
            /// A value indicating whether the operation should return 'recognitionModel'
            /// in response.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<FaceList> GetAsync(this IFaceListOperations operations, string faceListId, bool? returnRecognitionModel = false, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(faceListId, returnRecognitionModel, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update information of a face list.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='faceListId'>
            /// Id referencing a particular face list.
            /// </param>
            /// <param name='name'>
            /// User defined name, maximum length is 128.
            /// </param>
            /// <param name='userData'>
            /// User specified data. Length should not exceed 16KB.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UpdateAsync(this IFaceListOperations operations, string faceListId, string name = default(string), string userData = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.UpdateWithHttpMessagesAsync(faceListId, name, userData, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Delete a specified face list.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='faceListId'>
            /// Id referencing a particular face list.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IFaceListOperations operations, string faceListId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(faceListId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// List face lists’ faceListId, name, userData and recognitionModel. &lt;br
            /// /&gt;
            /// To get face information inside faceList use [FaceList -
            /// Get](/docs/services/563879b61984550e40cbbe8d/operations/563879b61984550f3039524c)
            ///
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='returnRecognitionModel'>
            /// A value indicating whether the operation should return 'recognitionModel'
            /// in response.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<FaceList>> ListAsync(this IFaceListOperations operations, bool? returnRecognitionModel = false, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(returnRecognitionModel, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a face from a face list by specified faceListId and persistedFaceId.
            /// &lt;br /&gt; Adding/deleting faces to/from a same face list are processed
            /// sequentially and to/from different face lists are in parallel.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='faceListId'>
            /// Id referencing a particular face list.
            /// </param>
            /// <param name='persistedFaceId'>
            /// Id referencing a particular persistedFaceId of an existing face.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteFaceAsync(this IFaceListOperations operations, string faceListId, System.Guid persistedFaceId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteFaceWithHttpMessagesAsync(faceListId, persistedFaceId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Add a face to a specified face list, up to 1,000 faces.
            /// &lt;br /&gt; To deal with an image contains multiple faces, input face can
            /// be specified as an image with a targetFace rectangle. It returns a
            /// persistedFaceId representing the added face. No image will be stored. Only
            /// the extracted face feature will be stored on server until [FaceList -
            /// Delete
            /// Face](/docs/services/563879b61984550e40cbbe8d/operations/563879b61984550f30395251)
            /// or [FaceList -
            /// Delete](/docs/services/563879b61984550e40cbbe8d/operations/563879b61984550f3039524f)
            /// is called.
            /// &lt;br /&gt; Note persistedFaceId is different from faceId generated by
            /// [Face -
            /// Detect](/docs/services/563879b61984550e40cbbe8d/operations/563879b61984550f30395236).
            /// * Higher face image quality means better detection and recognition
            /// precision. Please consider high-quality faces: frontal, clear, and face
            /// size is 200x200 pixels (100 pixels between eyes) or bigger.
            /// * JPEG, PNG, GIF (the first frame), and BMP format are supported. The
            /// allowed image file size is from 1KB to 6MB.
            /// * "targetFace" rectangle should contain one face. Zero or multiple faces
            /// will be regarded as an error. If the provided "targetFace" rectangle is not
            /// returned from [Face -
            /// Detect](/docs/services/563879b61984550e40cbbe8d/operations/563879b61984550f30395236),
            /// there’s no guarantee to detect and add the face successfully.
            /// * Out of detectable face size (36x36 - 4096x4096 pixels), large head-pose,
            /// or large occlusions will cause failures.
            /// * Adding/deleting faces to/from a same face list are processed sequentially
            /// and to/from different face lists are in parallel.
            /// * The minimum detectable face size is 36x36 pixels in an image no larger
            /// than 1920x1080 pixels. Images with dimensions higher than 1920x1080 pixels
            /// will need a proportionally larger minimum face size.
            /// * Different 'detectionModel' values can be provided. To use and compare
            /// different detection models, please refer to [How to specify a detection
            /// model](https://docs.microsoft.com/en-us/azure/cognitive-services/face/face-api-how-to-topics/specify-detection-model)
            /// | Model | Recommended use-case(s) |
            /// | ---------- | -------- |
            /// | 'detection_01': | The default detection model for [FaceList - Add
            /// Face](/docs/services/563879b61984550e40cbbe8d/operations/563879b61984550f30395250).
            /// Recommend for near frontal face detection. For scenarios with exceptionally
            /// large angle (head-pose) faces, occluded faces or wrong image orientation,
            /// the faces in such cases may not be detected. |
            /// | 'detection_02': | Detection model released in 2019 May with improved
            /// accuracy especially on small, side and blurry faces. |
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='faceListId'>
            /// Id referencing a particular face list.
            /// </param>
            /// <param name='url'>
            /// Publicly reachable URL of an image
            /// </param>
            /// <param name='userData'>
            /// User-specified data about the face for any purpose. The maximum length is
            /// 1KB.
            /// </param>
            /// <param name='targetFace'>
            /// A face rectangle to specify the target face to be added to a person in the
            /// format of "targetFace=left,top,width,height". E.g.
            /// "targetFace=10,10,100,100". If there is more than one face in the image,
            /// targetFace is required to specify which face to add. No targetFace means
            /// there is only one face detected in the entire image.
            /// </param>
            /// <param name='detectionModel'>
            /// Name of detection model. Detection model is used to detect faces in the
            /// submitted image. A detection model name can be provided when performing
            /// Face - Detect or (Large)FaceList - Add Face or (Large)PersonGroup - Add
            /// Face. The default value is 'detection_01', if another model is needed,
            /// please explicitly specify it. Possible values include: 'detection_01',
            /// 'detection_02'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PersistedFace> AddFaceFromUrlAsync(this IFaceListOperations operations, string faceListId, string url, string userData = default(string), IList<int> targetFace = default(IList<int>), string detectionModel = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.AddFaceFromUrlWithHttpMessagesAsync(faceListId, url, userData, targetFace, detectionModel, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Add a face to a specified face list, up to 1,000 faces.
            /// &lt;br /&gt; To deal with an image contains multiple faces, input face can
            /// be specified as an image with a targetFace rectangle. It returns a
            /// persistedFaceId representing the added face. No image will be stored. Only
            /// the extracted face feature will be stored on server until [FaceList -
            /// Delete
            /// Face](/docs/services/563879b61984550e40cbbe8d/operations/563879b61984550f30395251)
            /// or [FaceList -
            /// Delete](/docs/services/563879b61984550e40cbbe8d/operations/563879b61984550f3039524f)
            /// is called.
            /// &lt;br /&gt; Note persistedFaceId is different from faceId generated by
            /// [Face -
            /// Detect](/docs/services/563879b61984550e40cbbe8d/operations/563879b61984550f30395236).
            /// * Higher face image quality means better detection and recognition
            /// precision. Please consider high-quality faces: frontal, clear, and face
            /// size is 200x200 pixels (100 pixels between eyes) or bigger.
            /// * JPEG, PNG, GIF (the first frame), and BMP format are supported. The
            /// allowed image file size is from 1KB to 6MB.
            /// * "targetFace" rectangle should contain one face. Zero or multiple faces
            /// will be regarded as an error. If the provided "targetFace" rectangle is not
            /// returned from [Face -
            /// Detect](/docs/services/563879b61984550e40cbbe8d/operations/563879b61984550f30395236),
            /// there’s no guarantee to detect and add the face successfully.
            /// * Out of detectable face size (36x36 - 4096x4096 pixels), large head-pose,
            /// or large occlusions will cause failures.
            /// * Adding/deleting faces to/from a same face list are processed sequentially
            /// and to/from different face lists are in parallel.
            /// * The minimum detectable face size is 36x36 pixels in an image no larger
            /// than 1920x1080 pixels. Images with dimensions higher than 1920x1080 pixels
            /// will need a proportionally larger minimum face size.
            /// * Different 'detectionModel' values can be provided. To use and compare
            /// different detection models, please refer to [How to specify a detection
            /// model](https://docs.microsoft.com/en-us/azure/cognitive-services/face/face-api-how-to-topics/specify-detection-model)
            /// | Model | Recommended use-case(s) |
            /// | ---------- | -------- |
            /// | 'detection_01': | The default detection model for [FaceList - Add
            /// Face](/docs/services/563879b61984550e40cbbe8d/operations/563879b61984550f30395250).
            /// Recommend for near frontal face detection. For scenarios with exceptionally
            /// large angle (head-pose) faces, occluded faces or wrong image orientation,
            /// the faces in such cases may not be detected. |
            /// | 'detection_02': | Detection model released in 2019 May with improved
            /// accuracy especially on small, side and blurry faces. |
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='faceListId'>
            /// Id referencing a particular face list.
            /// </param>
            /// <param name='image'>
            /// An image stream.
            /// </param>
            /// <param name='userData'>
            /// User-specified data about the face for any purpose. The maximum length is
            /// 1KB.
            /// </param>
            /// <param name='targetFace'>
            /// A face rectangle to specify the target face to be added to a person in the
            /// format of "targetFace=left,top,width,height". E.g.
            /// "targetFace=10,10,100,100". If there is more than one face in the image,
            /// targetFace is required to specify which face to add. No targetFace means
            /// there is only one face detected in the entire image.
            /// </param>
            /// <param name='detectionModel'>
            /// Name of detection model. Detection model is used to detect faces in the
            /// submitted image. A detection model name can be provided when performing
            /// Face - Detect or (Large)FaceList - Add Face or (Large)PersonGroup - Add
            /// Face. The default value is 'detection_01', if another model is needed,
            /// please explicitly specify it. Possible values include: 'detection_01',
            /// 'detection_02'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PersistedFace> AddFaceFromStreamAsync(this IFaceListOperations operations, string faceListId, Stream image, string userData = default(string), IList<int> targetFace = default(IList<int>), string detectionModel = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.AddFaceFromStreamWithHttpMessagesAsync(faceListId, image, userData, targetFace, detectionModel, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
