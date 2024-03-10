using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using dotnetReplicate.Client;
using dotnetReplicate.Model;

namespace dotnetReplicate.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDefaultApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get the authenticated account
        /// </summary>
        /// <remarks>
        /// Returns information about the user or organization associated with the provided API token.  Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/account &#x60;&#x60;&#x60;  The response will be a JSON object describing the account:  &#x60;&#x60;&#x60;json {   \&quot;type\&quot;: \&quot;organization\&quot;,   \&quot;username\&quot;: \&quot;acme\&quot;,   \&quot;name\&quot;: \&quot;Acme Corp, Inc.\&quot;,   \&quot;github_url\&quot;: \&quot;https://github.com/acme\&quot;, } &#x60;&#x60;&#x60; 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Account</returns>
        Account AccountGet(int operationIndex = 0);

        /// <summary>
        /// Get the authenticated account
        /// </summary>
        /// <remarks>
        /// Returns information about the user or organization associated with the provided API token.  Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/account &#x60;&#x60;&#x60;  The response will be a JSON object describing the account:  &#x60;&#x60;&#x60;json {   \&quot;type\&quot;: \&quot;organization\&quot;,   \&quot;username\&quot;: \&quot;acme\&quot;,   \&quot;name\&quot;: \&quot;Acme Corp, Inc.\&quot;,   \&quot;github_url\&quot;: \&quot;https://github.com/acme\&quot;, } &#x60;&#x60;&#x60; 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Account</returns>
        ApiResponse<Account> AccountGetWithHttpInfo(int operationIndex = 0);
        /// <summary>
        /// Get a collection of models
        /// </summary>
        /// <remarks>
        /// Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/collections/super-resolution &#x60;&#x60;&#x60;  The response will be a collection object with a nested list of the models in that collection:  &#x60;&#x60;&#x60;json {   \&quot;name\&quot;: \&quot;Super resolution\&quot;,   \&quot;slug\&quot;: \&quot;super-resolution\&quot;,   \&quot;description\&quot;: \&quot;Upscaling models that create high-quality images from low-quality images.\&quot;,   \&quot;models\&quot;: [...] } &#x60;&#x60;&#x60; 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="collectionSlug">The slug of the collection, like &#x60;super-resolution&#x60; or &#x60;image-restoration&#x60;. See [replicate.com/collections](https://replicate.com/collections). </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void CollectionsGet(string collectionSlug, int operationIndex = 0);

        /// <summary>
        /// Get a collection of models
        /// </summary>
        /// <remarks>
        /// Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/collections/super-resolution &#x60;&#x60;&#x60;  The response will be a collection object with a nested list of the models in that collection:  &#x60;&#x60;&#x60;json {   \&quot;name\&quot;: \&quot;Super resolution\&quot;,   \&quot;slug\&quot;: \&quot;super-resolution\&quot;,   \&quot;description\&quot;: \&quot;Upscaling models that create high-quality images from low-quality images.\&quot;,   \&quot;models\&quot;: [...] } &#x60;&#x60;&#x60; 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="collectionSlug">The slug of the collection, like &#x60;super-resolution&#x60; or &#x60;image-restoration&#x60;. See [replicate.com/collections](https://replicate.com/collections). </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> CollectionsGetWithHttpInfo(string collectionSlug, int operationIndex = 0);
        /// <summary>
        /// List collections of models
        /// </summary>
        /// <remarks>
        /// Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/collections &#x60;&#x60;&#x60;  The response will be a paginated JSON list of collection objects:  &#x60;&#x60;&#x60;json {   \&quot;next\&quot;: \&quot;null\&quot;,   \&quot;previous\&quot;: null,   \&quot;results\&quot;: [     {       \&quot;name\&quot;: \&quot;Super resolution\&quot;,       \&quot;slug\&quot;: \&quot;super-resolution\&quot;,       \&quot;description\&quot;: \&quot;Upscaling models that create high-quality images from low-quality images.\&quot;     }   ] } &#x60;&#x60;&#x60; 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void CollectionsList(int operationIndex = 0);

        /// <summary>
        /// List collections of models
        /// </summary>
        /// <remarks>
        /// Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/collections &#x60;&#x60;&#x60;  The response will be a paginated JSON list of collection objects:  &#x60;&#x60;&#x60;json {   \&quot;next\&quot;: \&quot;null\&quot;,   \&quot;previous\&quot;: null,   \&quot;results\&quot;: [     {       \&quot;name\&quot;: \&quot;Super resolution\&quot;,       \&quot;slug\&quot;: \&quot;super-resolution\&quot;,       \&quot;description\&quot;: \&quot;Upscaling models that create high-quality images from low-quality images.\&quot;     }   ] } &#x60;&#x60;&#x60; 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> CollectionsListWithHttpInfo(int operationIndex = 0);
        /// <summary>
        /// Get a deployment
        /// </summary>
        /// <remarks>
        /// Get information about a deployment by name including the current release.  Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token   &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/deployments/replicate/my-app-image-generator &#x60;&#x60;&#x60;  The response will be a JSON object describing the deployment:  &#x60;&#x60;&#x60;json {   \&quot;owner\&quot;: \&quot;replicate\&quot;,   \&quot;name\&quot;: \&quot;my-app-image-generator\&quot;,   \&quot;current_release\&quot;: {     \&quot;number\&quot;: 1,     \&quot;model\&quot;: \&quot;stability-ai/sdxl\&quot;,     \&quot;version\&quot;: \&quot;da77bc59ee60423279fd632efb4795ab731d9e3ca9705ef3341091fb989b7eaf\&quot;,     \&quot;created_at\&quot;: \&quot;2024-02-15T16:32:57.018467Z\&quot;,     \&quot;created_by\&quot;: {       \&quot;type\&quot;: \&quot;organization\&quot;,       \&quot;username\&quot;: \&quot;acme\&quot;,       \&quot;name\&quot;: \&quot;Acme Corp, Inc.\&quot;,       \&quot;github_url\&quot;: \&quot;https://github.com/acme\&quot;,     },     \&quot;configuration\&quot;: {       \&quot;hardware\&quot;: \&quot;gpu-t4\&quot;,       \&quot;scaling\&quot;: {         \&quot;min_instances\&quot;: 1,         \&quot;max_instances\&quot;: 5       }     }   } } &#x60;&#x60;&#x60; 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentOwner">The name of the user or organization that owns the deployment. </param>
        /// <param name="deploymentName">The name of the deployment. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>DeploymentsGet200Response</returns>
        Deployment DeploymentsGet(string deploymentOwner, string deploymentName, int operationIndex = 0);

        /// <summary>
        /// Get a deployment
        /// </summary>
        /// <remarks>
        /// Get information about a deployment by name including the current release.  Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token   &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/deployments/replicate/my-app-image-generator &#x60;&#x60;&#x60;  The response will be a JSON object describing the deployment:  &#x60;&#x60;&#x60;json {   \&quot;owner\&quot;: \&quot;replicate\&quot;,   \&quot;name\&quot;: \&quot;my-app-image-generator\&quot;,   \&quot;current_release\&quot;: {     \&quot;number\&quot;: 1,     \&quot;model\&quot;: \&quot;stability-ai/sdxl\&quot;,     \&quot;version\&quot;: \&quot;da77bc59ee60423279fd632efb4795ab731d9e3ca9705ef3341091fb989b7eaf\&quot;,     \&quot;created_at\&quot;: \&quot;2024-02-15T16:32:57.018467Z\&quot;,     \&quot;created_by\&quot;: {       \&quot;type\&quot;: \&quot;organization\&quot;,       \&quot;username\&quot;: \&quot;acme\&quot;,       \&quot;name\&quot;: \&quot;Acme Corp, Inc.\&quot;,       \&quot;github_url\&quot;: \&quot;https://github.com/acme\&quot;,     },     \&quot;configuration\&quot;: {       \&quot;hardware\&quot;: \&quot;gpu-t4\&quot;,       \&quot;scaling\&quot;: {         \&quot;min_instances\&quot;: 1,         \&quot;max_instances\&quot;: 5       }     }   } } &#x60;&#x60;&#x60; 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentOwner">The name of the user or organization that owns the deployment. </param>
        /// <param name="deploymentName">The name of the deployment. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of DeploymentsGet200Response</returns>
        ApiResponse<Deployment> DeploymentsGetWithHttpInfo(string deploymentOwner, string deploymentName, int operationIndex = 0);
        /// <summary>
        /// List available hardware for models
        /// </summary>
        /// <remarks>
        /// Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/hardware &#x60;&#x60;&#x60;  The response will be a JSON array of hardware objects:  &#x60;&#x60;&#x60;json [     {\&quot;name\&quot;: \&quot;CPU\&quot;, \&quot;sku\&quot;: \&quot;cpu\&quot;},     {\&quot;name\&quot;: \&quot;Nvidia T4 GPU\&quot;, \&quot;sku\&quot;: \&quot;gpu-t4\&quot;},     {\&quot;name\&quot;: \&quot;Nvidia A40 GPU\&quot;, \&quot;sku\&quot;: \&quot;gpu-a40-small\&quot;},     {\&quot;name\&quot;: \&quot;Nvidia A40 (Large) GPU\&quot;, \&quot;sku\&quot;: \&quot;gpu-a40-large\&quot;}, ] &#x60;&#x60;&#x60; 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;HardwareList200ResponseInner&gt;</returns>
        List<HardwareListResponse> HardwareList(int operationIndex = 0);

        /// <summary>
        /// List available hardware for models
        /// </summary>
        /// <remarks>
        /// Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/hardware &#x60;&#x60;&#x60;  The response will be a JSON array of hardware objects:  &#x60;&#x60;&#x60;json [     {\&quot;name\&quot;: \&quot;CPU\&quot;, \&quot;sku\&quot;: \&quot;cpu\&quot;},     {\&quot;name\&quot;: \&quot;Nvidia T4 GPU\&quot;, \&quot;sku\&quot;: \&quot;gpu-t4\&quot;},     {\&quot;name\&quot;: \&quot;Nvidia A40 GPU\&quot;, \&quot;sku\&quot;: \&quot;gpu-a40-small\&quot;},     {\&quot;name\&quot;: \&quot;Nvidia A40 (Large) GPU\&quot;, \&quot;sku\&quot;: \&quot;gpu-a40-large\&quot;}, ] &#x60;&#x60;&#x60; 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;HardwareList200ResponseInner&gt;</returns>
        ApiResponse<List<HardwareListResponse>> HardwareListWithHttpInfo(int operationIndex = 0);
        /// <summary>
        /// Create a model
        /// </summary>
        /// <remarks>
        /// Create a model.  Example cURL request:  &#x60;&#x60;&#x60;console curl -s -X POST \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   -d &#39;{\&quot;owner\&quot;: \&quot;alice\&quot; \&quot;name\&quot;: \&quot;my-model\&quot;, \&quot;description\&quot;: \&quot;An example model\&quot;, \&quot;visibility\&quot;: \&quot;public\&quot;, \&quot;hardware\&quot;: \&quot;cpu\&quot;}&#39; \\   https://api.replicate.com/v1/models &#x60;&#x60;&#x60;  The response will be a model object in the following format:  &#x60;&#x60;&#x60;json {   \&quot;url\&quot;: \&quot;https://replicate.com/alice/my-model\&quot;,   \&quot;owner\&quot;: \&quot;alice\&quot;,   \&quot;name\&quot;: \&quot;my-model\&quot;,   \&quot;description\&quot;: \&quot;An example model\&quot;,   \&quot;visibility\&quot;: \&quot;public\&quot;,   \&quot;github_url\&quot;: null,   \&quot;paper_url\&quot;: null,   \&quot;license_url\&quot;: null,   \&quot;run_count\&quot;: 0,   \&quot;cover_image_url\&quot;: null,   \&quot;default_example\&quot;: null,   \&quot;latest_version\&quot;: null, } &#x60;&#x60;&#x60; 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelsCreateRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void ModelsCreate(ModelsCreateRequest modelsCreateRequest, int operationIndex = 0);

        /// <summary>
        /// Create a model
        /// </summary>
        /// <remarks>
        /// Create a model.  Example cURL request:  &#x60;&#x60;&#x60;console curl -s -X POST \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   -d &#39;{\&quot;owner\&quot;: \&quot;alice\&quot; \&quot;name\&quot;: \&quot;my-model\&quot;, \&quot;description\&quot;: \&quot;An example model\&quot;, \&quot;visibility\&quot;: \&quot;public\&quot;, \&quot;hardware\&quot;: \&quot;cpu\&quot;}&#39; \\   https://api.replicate.com/v1/models &#x60;&#x60;&#x60;  The response will be a model object in the following format:  &#x60;&#x60;&#x60;json {   \&quot;url\&quot;: \&quot;https://replicate.com/alice/my-model\&quot;,   \&quot;owner\&quot;: \&quot;alice\&quot;,   \&quot;name\&quot;: \&quot;my-model\&quot;,   \&quot;description\&quot;: \&quot;An example model\&quot;,   \&quot;visibility\&quot;: \&quot;public\&quot;,   \&quot;github_url\&quot;: null,   \&quot;paper_url\&quot;: null,   \&quot;license_url\&quot;: null,   \&quot;run_count\&quot;: 0,   \&quot;cover_image_url\&quot;: null,   \&quot;default_example\&quot;: null,   \&quot;latest_version\&quot;: null, } &#x60;&#x60;&#x60; 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelsCreateRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ModelsCreateWithHttpInfo(ModelsCreateRequest modelsCreateRequest, int operationIndex = 0);
        /// <summary>
        /// Get a model
        /// </summary>
        /// <remarks>
        /// Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/models/replicate/hello-world &#x60;&#x60;&#x60;  The response will be a model object in the following format:  &#x60;&#x60;&#x60;json {   \&quot;url\&quot;: \&quot;https://replicate.com/replicate/hello-world\&quot;,   \&quot;owner\&quot;: \&quot;replicate\&quot;,   \&quot;name\&quot;: \&quot;hello-world\&quot;,   \&quot;description\&quot;: \&quot;A tiny model that says hello\&quot;,   \&quot;visibility\&quot;: \&quot;public\&quot;,   \&quot;github_url\&quot;: \&quot;https://github.com/replicate/cog-examples\&quot;,   \&quot;paper_url\&quot;: null,   \&quot;license_url\&quot;: null,   \&quot;run_count\&quot;: 5681081,   \&quot;cover_image_url\&quot;: \&quot;...\&quot;,   \&quot;default_example\&quot;: {...},   \&quot;latest_version\&quot;: {...}, } &#x60;&#x60;&#x60;  The &#x60;cover_image_url&#x60; string is an HTTPS URL for an image file. This can be:  - An image uploaded by the model author. - The output file of the example prediction, if the model author has not set a cover image. - The input file of the example prediction, if the model author has not set a cover image and the example prediction has no output file. - A generic fallback image.  The &#x60;default_example&#x60; object is a [prediction](#predictions.get) created with this model.  The &#x60;latest_version&#x60; object is the model&#39;s most recently pushed [version](#models.versions.get). 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelOwner">The name of the user or organization that owns the model. </param>
        /// <param name="modelName">The name of the model. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void ModelsGet(string modelOwner, string modelName, int operationIndex = 0);

        /// <summary>
        /// Get a model
        /// </summary>
        /// <remarks>
        /// Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/models/replicate/hello-world &#x60;&#x60;&#x60;  The response will be a model object in the following format:  &#x60;&#x60;&#x60;json {   \&quot;url\&quot;: \&quot;https://replicate.com/replicate/hello-world\&quot;,   \&quot;owner\&quot;: \&quot;replicate\&quot;,   \&quot;name\&quot;: \&quot;hello-world\&quot;,   \&quot;description\&quot;: \&quot;A tiny model that says hello\&quot;,   \&quot;visibility\&quot;: \&quot;public\&quot;,   \&quot;github_url\&quot;: \&quot;https://github.com/replicate/cog-examples\&quot;,   \&quot;paper_url\&quot;: null,   \&quot;license_url\&quot;: null,   \&quot;run_count\&quot;: 5681081,   \&quot;cover_image_url\&quot;: \&quot;...\&quot;,   \&quot;default_example\&quot;: {...},   \&quot;latest_version\&quot;: {...}, } &#x60;&#x60;&#x60;  The &#x60;cover_image_url&#x60; string is an HTTPS URL for an image file. This can be:  - An image uploaded by the model author. - The output file of the example prediction, if the model author has not set a cover image. - The input file of the example prediction, if the model author has not set a cover image and the example prediction has no output file. - A generic fallback image.  The &#x60;default_example&#x60; object is a [prediction](#predictions.get) created with this model.  The &#x60;latest_version&#x60; object is the model&#39;s most recently pushed [version](#models.versions.get). 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelOwner">The name of the user or organization that owns the model. </param>
        /// <param name="modelName">The name of the model. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ModelsGetWithHttpInfo(string modelOwner, string modelName, int operationIndex = 0);
        /// <summary>
        /// List public models
        /// </summary>
        /// <remarks>
        /// Get a paginated list of public models.  Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/models &#x60;&#x60;&#x60;  The response will be a paginated JSON array of model objects:  &#x60;&#x60;&#x60;json {   \&quot;next\&quot;: null,   \&quot;previous\&quot;: null,   \&quot;results\&quot;: [     {       \&quot;url\&quot;: \&quot;https://replicate.com/replicate/hello-world\&quot;,       \&quot;owner\&quot;: \&quot;replicate\&quot;,       \&quot;name\&quot;: \&quot;hello-world\&quot;,       \&quot;description\&quot;: \&quot;A tiny model that says hello\&quot;,       \&quot;visibility\&quot;: \&quot;public\&quot;,       \&quot;github_url\&quot;: \&quot;https://github.com/replicate/cog-examples\&quot;,       \&quot;paper_url\&quot;: null,       \&quot;license_url\&quot;: null,       \&quot;run_count\&quot;: 5681081,       \&quot;cover_image_url\&quot;: \&quot;...\&quot;,       \&quot;default_example\&quot;: {...},       \&quot;latest_version\&quot;: {...}     }   ] } &#x60;&#x60;&#x60;  The &#x60;cover_image_url&#x60; string is an HTTPS URL for an image file. This can be:  - An image uploaded by the model author. - The output file of the example prediction, if the model author has not set a cover image. - The input file of the example prediction, if the model author has not set a cover image and the example prediction has no output file. - A generic fallback image. 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void ModelsList(int operationIndex = 0);

        /// <summary>
        /// List public models
        /// </summary>
        /// <remarks>
        /// Get a paginated list of public models.  Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/models &#x60;&#x60;&#x60;  The response will be a paginated JSON array of model objects:  &#x60;&#x60;&#x60;json {   \&quot;next\&quot;: null,   \&quot;previous\&quot;: null,   \&quot;results\&quot;: [     {       \&quot;url\&quot;: \&quot;https://replicate.com/replicate/hello-world\&quot;,       \&quot;owner\&quot;: \&quot;replicate\&quot;,       \&quot;name\&quot;: \&quot;hello-world\&quot;,       \&quot;description\&quot;: \&quot;A tiny model that says hello\&quot;,       \&quot;visibility\&quot;: \&quot;public\&quot;,       \&quot;github_url\&quot;: \&quot;https://github.com/replicate/cog-examples\&quot;,       \&quot;paper_url\&quot;: null,       \&quot;license_url\&quot;: null,       \&quot;run_count\&quot;: 5681081,       \&quot;cover_image_url\&quot;: \&quot;...\&quot;,       \&quot;default_example\&quot;: {...},       \&quot;latest_version\&quot;: {...}     }   ] } &#x60;&#x60;&#x60;  The &#x60;cover_image_url&#x60; string is an HTTPS URL for an image file. This can be:  - An image uploaded by the model author. - The output file of the example prediction, if the model author has not set a cover image. - The input file of the example prediction, if the model author has not set a cover image and the example prediction has no output file. - A generic fallback image. 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ModelsListWithHttpInfo(int operationIndex = 0);
        /// <summary>
        /// Delete a model version
        /// </summary>
        /// <remarks>
        /// Delete a model version and all associated predictions, including all output files.  Model version deletion has some restrictions:  - You can only delete versions from models you own. - You can only delete versions from private models. - You cannot delete a version if someone other than you has run predictions with it.  Example cURL request:  &#x60;&#x60;&#x60;command curl -s -X DELETE \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/models/replicate/hello-world/versions/5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa &#x60;&#x60;&#x60;  The response will be an empty 202, indicating the deletion request has been accepted. It might take a few minutes to be processed. 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelOwner">The name of the user or organization that owns the model. </param>
        /// <param name="modelName">The name of the model. </param>
        /// <param name="versionId">The ID of the version. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void ModelsVersionsDelete(string modelOwner, string modelName, string versionId, int operationIndex = 0);

        /// <summary>
        /// Delete a model version
        /// </summary>
        /// <remarks>
        /// Delete a model version and all associated predictions, including all output files.  Model version deletion has some restrictions:  - You can only delete versions from models you own. - You can only delete versions from private models. - You cannot delete a version if someone other than you has run predictions with it.  Example cURL request:  &#x60;&#x60;&#x60;command curl -s -X DELETE \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/models/replicate/hello-world/versions/5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa &#x60;&#x60;&#x60;  The response will be an empty 202, indicating the deletion request has been accepted. It might take a few minutes to be processed. 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelOwner">The name of the user or organization that owns the model. </param>
        /// <param name="modelName">The name of the model. </param>
        /// <param name="versionId">The ID of the version. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ModelsVersionsDeleteWithHttpInfo(string modelOwner, string modelName, string versionId, int operationIndex = 0);
        /// <summary>
        /// Get a model version
        /// </summary>
        /// <remarks>
        /// Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/models/replicate/hello-world/versions/5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa &#x60;&#x60;&#x60;  The response will be the version object:  &#x60;&#x60;&#x60;json {   \&quot;id\&quot;: \&quot;5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa\&quot;,   \&quot;created_at\&quot;: \&quot;2022-04-26T19:29:04.418669Z\&quot;,   \&quot;cog_version\&quot;: \&quot;0.3.0\&quot;,   \&quot;openapi_schema\&quot;: {...} } &#x60;&#x60;&#x60;  Every model describes its inputs and outputs with [OpenAPI Schema Objects](https://spec.openapis.org/oas/latest.html#schemaObject) in the &#x60;openapi_schema&#x60; property.  The &#x60;openapi_schema.components.schemas.Input&#x60; property for the [replicate/hello-world](https://replicate.com/replicate/hello-world) model looks like this:  &#x60;&#x60;&#x60;json {   \&quot;type\&quot;: \&quot;object\&quot;,   \&quot;title\&quot;: \&quot;Input\&quot;,   \&quot;required\&quot;: [     \&quot;text\&quot;   ],   \&quot;properties\&quot;: {     \&quot;text\&quot;: {       \&quot;x-order\&quot;: 0,       \&quot;type\&quot;: \&quot;string\&quot;,       \&quot;title\&quot;: \&quot;Text\&quot;,       \&quot;description\&quot;: \&quot;Text to prefix with &#39;hello &#39;\&quot;     }   } } &#x60;&#x60;&#x60;  The &#x60;openapi_schema.components.schemas.Output&#x60; property for the [replicate/hello-world](https://replicate.com/replicate/hello-world) model looks like this:  &#x60;&#x60;&#x60;json {   \&quot;type\&quot;: \&quot;string\&quot;,   \&quot;title\&quot;: \&quot;Output\&quot; } &#x60;&#x60;&#x60;  For more details, see the docs on [Cog&#39;s supported input and output types](https://github.com/replicate/cog/blob/75b7802219e7cd4cee845e34c4c22139558615d4/docs/python.md#input-and-output-types) 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelOwner">The name of the user or organization that owns the model. </param>
        /// <param name="modelName">The name of the model. </param>
        /// <param name="versionId">The ID of the version. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void ModelsVersionsGet(string modelOwner, string modelName, string versionId, int operationIndex = 0);

        /// <summary>
        /// Get a model version
        /// </summary>
        /// <remarks>
        /// Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/models/replicate/hello-world/versions/5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa &#x60;&#x60;&#x60;  The response will be the version object:  &#x60;&#x60;&#x60;json {   \&quot;id\&quot;: \&quot;5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa\&quot;,   \&quot;created_at\&quot;: \&quot;2022-04-26T19:29:04.418669Z\&quot;,   \&quot;cog_version\&quot;: \&quot;0.3.0\&quot;,   \&quot;openapi_schema\&quot;: {...} } &#x60;&#x60;&#x60;  Every model describes its inputs and outputs with [OpenAPI Schema Objects](https://spec.openapis.org/oas/latest.html#schemaObject) in the &#x60;openapi_schema&#x60; property.  The &#x60;openapi_schema.components.schemas.Input&#x60; property for the [replicate/hello-world](https://replicate.com/replicate/hello-world) model looks like this:  &#x60;&#x60;&#x60;json {   \&quot;type\&quot;: \&quot;object\&quot;,   \&quot;title\&quot;: \&quot;Input\&quot;,   \&quot;required\&quot;: [     \&quot;text\&quot;   ],   \&quot;properties\&quot;: {     \&quot;text\&quot;: {       \&quot;x-order\&quot;: 0,       \&quot;type\&quot;: \&quot;string\&quot;,       \&quot;title\&quot;: \&quot;Text\&quot;,       \&quot;description\&quot;: \&quot;Text to prefix with &#39;hello &#39;\&quot;     }   } } &#x60;&#x60;&#x60;  The &#x60;openapi_schema.components.schemas.Output&#x60; property for the [replicate/hello-world](https://replicate.com/replicate/hello-world) model looks like this:  &#x60;&#x60;&#x60;json {   \&quot;type\&quot;: \&quot;string\&quot;,   \&quot;title\&quot;: \&quot;Output\&quot; } &#x60;&#x60;&#x60;  For more details, see the docs on [Cog&#39;s supported input and output types](https://github.com/replicate/cog/blob/75b7802219e7cd4cee845e34c4c22139558615d4/docs/python.md#input-and-output-types) 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelOwner">The name of the user or organization that owns the model. </param>
        /// <param name="modelName">The name of the model. </param>
        /// <param name="versionId">The ID of the version. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ModelsVersionsGetWithHttpInfo(string modelOwner, string modelName, string versionId, int operationIndex = 0);
        /// <summary>
        /// List model versions
        /// </summary>
        /// <remarks>
        /// Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/models/replicate/hello-world/versions &#x60;&#x60;&#x60;  The response will be a JSON array of model version objects, sorted with the most recent version first:  &#x60;&#x60;&#x60;json {   \&quot;next\&quot;: null,   \&quot;previous\&quot;: null,   \&quot;results\&quot;: [     {       \&quot;id\&quot;: \&quot;5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa\&quot;,       \&quot;created_at\&quot;: \&quot;2022-04-26T19:29:04.418669Z\&quot;,       \&quot;cog_version\&quot;: \&quot;0.3.0\&quot;,       \&quot;openapi_schema\&quot;: {...}     }   ] } &#x60;&#x60;&#x60; 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelOwner">The name of the user or organization that owns the model. </param>
        /// <param name="modelName">The name of the model. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void ModelsVersionsList(string modelOwner, string modelName, int operationIndex = 0);

        /// <summary>
        /// List model versions
        /// </summary>
        /// <remarks>
        /// Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/models/replicate/hello-world/versions &#x60;&#x60;&#x60;  The response will be a JSON array of model version objects, sorted with the most recent version first:  &#x60;&#x60;&#x60;json {   \&quot;next\&quot;: null,   \&quot;previous\&quot;: null,   \&quot;results\&quot;: [     {       \&quot;id\&quot;: \&quot;5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa\&quot;,       \&quot;created_at\&quot;: \&quot;2022-04-26T19:29:04.418669Z\&quot;,       \&quot;cog_version\&quot;: \&quot;0.3.0\&quot;,       \&quot;openapi_schema\&quot;: {...}     }   ] } &#x60;&#x60;&#x60; 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelOwner">The name of the user or organization that owns the model. </param>
        /// <param name="modelName">The name of the model. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ModelsVersionsListWithHttpInfo(string modelOwner, string modelName, int operationIndex = 0);
        /// <summary>
        /// Cancel a prediction
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="predictionId">The ID of the prediction to cancel. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void PredictionsCancel(string predictionId, int operationIndex = 0);

        /// <summary>
        /// Cancel a prediction
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="predictionId">The ID of the prediction to cancel. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PredictionsCancelWithHttpInfo(string predictionId, int operationIndex = 0);
        /// <summary>
        /// Create a prediction
        /// </summary>
        /// <remarks>
        /// Start a new prediction for the model version and inputs you provide.  Example request body:  &#x60;&#x60;&#x60;json {   \&quot;version\&quot;: \&quot;5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa\&quot;,   \&quot;input\&quot;: {     \&quot;text\&quot;: \&quot;Alice\&quot;   } } &#x60;&#x60;&#x60;  Example cURL request:  &#x60;&#x60;&#x60;console curl -s -X POST \\   -d &#39;{\&quot;version\&quot;: \&quot;5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa\&quot;, \&quot;input\&quot;: {\&quot;text\&quot;: \&quot;Alice\&quot;}}&#39; \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   -H &#39;Content-Type: application/json&#39; \\   https://api.replicate.com/v1/predictions &#x60;&#x60;&#x60;  The response will be the prediction object:  &#x60;&#x60;&#x60;json {   \&quot;id\&quot;: \&quot;gm3qorzdhgbfurvjtvhg6dckhu\&quot;,   \&quot;model\&quot;: \&quot;replicate/hello-world\&quot;,   \&quot;version\&quot;: \&quot;5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa\&quot;,   \&quot;input\&quot;: {     \&quot;text\&quot;: \&quot;Alice\&quot;   },   \&quot;logs\&quot;: \&quot;\&quot;,   \&quot;error\&quot;: null,   \&quot;status\&quot;: \&quot;starting\&quot;,   \&quot;created_at\&quot;: \&quot;2023-09-08T16:19:34.765994657Z\&quot;,   \&quot;urls\&quot;: {     \&quot;cancel\&quot;: \&quot;https://api.replicate.com/v1/predictions/gm3qorzdhgbfurvjtvhg6dckhu/cancel\&quot;,     \&quot;get\&quot;: \&quot;https://api.replicate.com/v1/predictions/gm3qorzdhgbfurvjtvhg6dckhu\&quot;   } } &#x60;&#x60;&#x60;  As models can take several seconds or more to run, the output will not be available immediately. To get the final result of the prediction you should either provide a &#x60;webhook&#x60; HTTPS URL for us to call when the results are ready, or poll the [get a prediction](#predictions.get) endpoint until it has finished.  Input and output (including any files) will be automatically deleted after an hour, so you must save a copy of any files in the output if you&#39;d like to continue using them.  Output files are served by &#x60;replicate.delivery&#x60; and its subdomains. If you use an allow list of external domains for your assets, add &#x60;replicate.delivery&#x60; and &#x60;*.replicate.delivery&#x60; to it. 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="predictionsCreateRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void PredictionsCreate(PredictionsCreateRequest? predictionsCreateRequest = default(PredictionsCreateRequest?), int operationIndex = 0);

        /// <summary>
        /// Create a prediction
        /// </summary>
        /// <remarks>
        /// Start a new prediction for the model version and inputs you provide.  Example request body:  &#x60;&#x60;&#x60;json {   \&quot;version\&quot;: \&quot;5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa\&quot;,   \&quot;input\&quot;: {     \&quot;text\&quot;: \&quot;Alice\&quot;   } } &#x60;&#x60;&#x60;  Example cURL request:  &#x60;&#x60;&#x60;console curl -s -X POST \\   -d &#39;{\&quot;version\&quot;: \&quot;5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa\&quot;, \&quot;input\&quot;: {\&quot;text\&quot;: \&quot;Alice\&quot;}}&#39; \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   -H &#39;Content-Type: application/json&#39; \\   https://api.replicate.com/v1/predictions &#x60;&#x60;&#x60;  The response will be the prediction object:  &#x60;&#x60;&#x60;json {   \&quot;id\&quot;: \&quot;gm3qorzdhgbfurvjtvhg6dckhu\&quot;,   \&quot;model\&quot;: \&quot;replicate/hello-world\&quot;,   \&quot;version\&quot;: \&quot;5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa\&quot;,   \&quot;input\&quot;: {     \&quot;text\&quot;: \&quot;Alice\&quot;   },   \&quot;logs\&quot;: \&quot;\&quot;,   \&quot;error\&quot;: null,   \&quot;status\&quot;: \&quot;starting\&quot;,   \&quot;created_at\&quot;: \&quot;2023-09-08T16:19:34.765994657Z\&quot;,   \&quot;urls\&quot;: {     \&quot;cancel\&quot;: \&quot;https://api.replicate.com/v1/predictions/gm3qorzdhgbfurvjtvhg6dckhu/cancel\&quot;,     \&quot;get\&quot;: \&quot;https://api.replicate.com/v1/predictions/gm3qorzdhgbfurvjtvhg6dckhu\&quot;   } } &#x60;&#x60;&#x60;  As models can take several seconds or more to run, the output will not be available immediately. To get the final result of the prediction you should either provide a &#x60;webhook&#x60; HTTPS URL for us to call when the results are ready, or poll the [get a prediction](#predictions.get) endpoint until it has finished.  Input and output (including any files) will be automatically deleted after an hour, so you must save a copy of any files in the output if you&#39;d like to continue using them.  Output files are served by &#x60;replicate.delivery&#x60; and its subdomains. If you use an allow list of external domains for your assets, add &#x60;replicate.delivery&#x60; and &#x60;*.replicate.delivery&#x60; to it. 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="predictionsCreateRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PredictionsCreateWithHttpInfo(PredictionsCreateRequest? predictionsCreateRequest = default(PredictionsCreateRequest?), int operationIndex = 0);
        /// <summary>
        /// Get a prediction
        /// </summary>
        /// <remarks>
        /// Get the current state of a prediction.  Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/predictions/gm3qorzdhgbfurvjtvhg6dckhu &#x60;&#x60;&#x60;  The response will be the prediction object:  &#x60;&#x60;&#x60;json {   \&quot;id\&quot;: \&quot;gm3qorzdhgbfurvjtvhg6dckhu\&quot;,   \&quot;model\&quot;: \&quot;replicate/hello-world\&quot;,   \&quot;version\&quot;: \&quot;5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa\&quot;,   \&quot;input\&quot;: {     \&quot;text\&quot;: \&quot;Alice\&quot;   },   \&quot;logs\&quot;: \&quot;\&quot;,   \&quot;output\&quot;: \&quot;hello Alice\&quot;,   \&quot;error\&quot;: null,   \&quot;status\&quot;: \&quot;succeeded\&quot;,   \&quot;created_at\&quot;: \&quot;2023-09-08T16:19:34.765994Z\&quot;,   \&quot;started_at\&quot;: \&quot;2023-09-08T16:19:34.779176Z\&quot;,   \&quot;completed_at\&quot;: \&quot;2023-09-08T16:19:34.791859Z\&quot;,   \&quot;metrics\&quot;: {     \&quot;predict_time\&quot;: 0.012683   },   \&quot;urls\&quot;: {     \&quot;cancel\&quot;: \&quot;https://api.replicate.com/v1/predictions/gm3qorzdhgbfurvjtvhg6dckhu/cancel\&quot;,     \&quot;get\&quot;: \&quot;https://api.replicate.com/v1/predictions/gm3qorzdhgbfurvjtvhg6dckhu\&quot;   } } &#x60;&#x60;&#x60;  &#x60;status&#x60; will be one of:  - &#x60;starting&#x60;: the prediction is starting up. If this status lasts longer than a few seconds, then it&#39;s typically because a new worker is being started to run the prediction. - &#x60;processing&#x60;: the &#x60;predict()&#x60; method of the model is currently running. - &#x60;succeeded&#x60;: the prediction completed successfully. - &#x60;failed&#x60;: the prediction encountered an error during processing. - &#x60;canceled&#x60;: the prediction was canceled by its creator.  In the case of success, &#x60;output&#x60; will be an object containing the output of the model. Any files will be represented as HTTPS URLs. You&#39;ll need to pass the &#x60;Authorization&#x60; header to request them.  In the case of failure, &#x60;error&#x60; will contain the error encountered during the prediction.  Terminated predictions (with a status of &#x60;succeeded&#x60;, &#x60;failed&#x60;, or &#x60;canceled&#x60;) will include a &#x60;metrics&#x60; object with a &#x60;predict_time&#x60; property showing the amount of CPU or GPU time, in seconds, that the prediction used while running. It won&#39;t include time waiting for the prediction to start.  Input and output (including any files) are automatically deleted after an hour, so you must save a copy of any files in the output if you&#39;d like to continue using them.  Output files are served by &#x60;replicate.delivery&#x60; and its subdomains. If you use an allow list of external domains for your assets, add &#x60;replicate.delivery&#x60; and &#x60;*.replicate.delivery&#x60; to it. 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="predictionId">The ID of the prediction to get. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void PredictionsGet(string predictionId, int operationIndex = 0);

        /// <summary>
        /// Get a prediction
        /// </summary>
        /// <remarks>
        /// Get the current state of a prediction.  Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/predictions/gm3qorzdhgbfurvjtvhg6dckhu &#x60;&#x60;&#x60;  The response will be the prediction object:  &#x60;&#x60;&#x60;json {   \&quot;id\&quot;: \&quot;gm3qorzdhgbfurvjtvhg6dckhu\&quot;,   \&quot;model\&quot;: \&quot;replicate/hello-world\&quot;,   \&quot;version\&quot;: \&quot;5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa\&quot;,   \&quot;input\&quot;: {     \&quot;text\&quot;: \&quot;Alice\&quot;   },   \&quot;logs\&quot;: \&quot;\&quot;,   \&quot;output\&quot;: \&quot;hello Alice\&quot;,   \&quot;error\&quot;: null,   \&quot;status\&quot;: \&quot;succeeded\&quot;,   \&quot;created_at\&quot;: \&quot;2023-09-08T16:19:34.765994Z\&quot;,   \&quot;started_at\&quot;: \&quot;2023-09-08T16:19:34.779176Z\&quot;,   \&quot;completed_at\&quot;: \&quot;2023-09-08T16:19:34.791859Z\&quot;,   \&quot;metrics\&quot;: {     \&quot;predict_time\&quot;: 0.012683   },   \&quot;urls\&quot;: {     \&quot;cancel\&quot;: \&quot;https://api.replicate.com/v1/predictions/gm3qorzdhgbfurvjtvhg6dckhu/cancel\&quot;,     \&quot;get\&quot;: \&quot;https://api.replicate.com/v1/predictions/gm3qorzdhgbfurvjtvhg6dckhu\&quot;   } } &#x60;&#x60;&#x60;  &#x60;status&#x60; will be one of:  - &#x60;starting&#x60;: the prediction is starting up. If this status lasts longer than a few seconds, then it&#39;s typically because a new worker is being started to run the prediction. - &#x60;processing&#x60;: the &#x60;predict()&#x60; method of the model is currently running. - &#x60;succeeded&#x60;: the prediction completed successfully. - &#x60;failed&#x60;: the prediction encountered an error during processing. - &#x60;canceled&#x60;: the prediction was canceled by its creator.  In the case of success, &#x60;output&#x60; will be an object containing the output of the model. Any files will be represented as HTTPS URLs. You&#39;ll need to pass the &#x60;Authorization&#x60; header to request them.  In the case of failure, &#x60;error&#x60; will contain the error encountered during the prediction.  Terminated predictions (with a status of &#x60;succeeded&#x60;, &#x60;failed&#x60;, or &#x60;canceled&#x60;) will include a &#x60;metrics&#x60; object with a &#x60;predict_time&#x60; property showing the amount of CPU or GPU time, in seconds, that the prediction used while running. It won&#39;t include time waiting for the prediction to start.  Input and output (including any files) are automatically deleted after an hour, so you must save a copy of any files in the output if you&#39;d like to continue using them.  Output files are served by &#x60;replicate.delivery&#x60; and its subdomains. If you use an allow list of external domains for your assets, add &#x60;replicate.delivery&#x60; and &#x60;*.replicate.delivery&#x60; to it. 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="predictionId">The ID of the prediction to get. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PredictionsGetWithHttpInfo(string predictionId, int operationIndex = 0);
        /// <summary>
        /// List predictions
        /// </summary>
        /// <remarks>
        /// Get a paginated list of predictions that you&#39;ve created. This will include predictions created from the API and the website. It will return 100 records per page.  Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/predictions &#x60;&#x60;&#x60;  The response will be a paginated JSON array of prediction objects, sorted with the most recent prediction first:  &#x60;&#x60;&#x60;json {   \&quot;next\&quot;: null,   \&quot;previous\&quot;: null,   \&quot;results\&quot;: [     {       \&quot;completed_at\&quot;: \&quot;2023-09-08T16:19:34.791859Z\&quot;,       \&quot;created_at\&quot;: \&quot;2023-09-08T16:19:34.907244Z\&quot;,       \&quot;error\&quot;: null,       \&quot;id\&quot;: \&quot;gm3qorzdhgbfurvjtvhg6dckhu\&quot;,       \&quot;input\&quot;: {         \&quot;text\&quot;: \&quot;Alice\&quot;       },       \&quot;metrics\&quot;: {         \&quot;predict_time\&quot;: 0.012683       },       \&quot;output\&quot;: \&quot;hello Alice\&quot;,       \&quot;started_at\&quot;: \&quot;2023-09-08T16:19:34.779176Z\&quot;,       \&quot;source\&quot;: \&quot;api\&quot;,       \&quot;status\&quot;: \&quot;succeeded\&quot;,       \&quot;urls\&quot;: {         \&quot;get\&quot;: \&quot;https://api.replicate.com/v1/predictions/gm3qorzdhgbfurvjtvhg6dckhu\&quot;,         \&quot;cancel\&quot;: \&quot;https://api.replicate.com/v1/predictions/gm3qorzdhgbfurvjtvhg6dckhu/cancel\&quot;       },       \&quot;model\&quot;: \&quot;replicate/hello-world\&quot;,       \&quot;version\&quot;: \&quot;5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa\&quot;,     }   ] } &#x60;&#x60;&#x60;  &#x60;id&#x60; will be the unique ID of the prediction.  &#x60;source&#x60; will indicate how the prediction was created. Possible values are &#x60;web&#x60; or &#x60;api&#x60;.  &#x60;status&#x60; will be the status of the prediction. Refer to [get a single prediction](#predictions.get) for possible values.  &#x60;urls&#x60; will be a convenience object that can be used to construct new API requests for the given prediction.  &#x60;model&#x60; will be the model identifier string in the format of &#x60;{model_owner}/{model_name}&#x60;.  &#x60;version&#x60; will be the unique ID of model version used to create the prediction. 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void PredictionsList(int operationIndex = 0);

        /// <summary>
        /// List predictions
        /// </summary>
        /// <remarks>
        /// Get a paginated list of predictions that you&#39;ve created. This will include predictions created from the API and the website. It will return 100 records per page.  Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/predictions &#x60;&#x60;&#x60;  The response will be a paginated JSON array of prediction objects, sorted with the most recent prediction first:  &#x60;&#x60;&#x60;json {   \&quot;next\&quot;: null,   \&quot;previous\&quot;: null,   \&quot;results\&quot;: [     {       \&quot;completed_at\&quot;: \&quot;2023-09-08T16:19:34.791859Z\&quot;,       \&quot;created_at\&quot;: \&quot;2023-09-08T16:19:34.907244Z\&quot;,       \&quot;error\&quot;: null,       \&quot;id\&quot;: \&quot;gm3qorzdhgbfurvjtvhg6dckhu\&quot;,       \&quot;input\&quot;: {         \&quot;text\&quot;: \&quot;Alice\&quot;       },       \&quot;metrics\&quot;: {         \&quot;predict_time\&quot;: 0.012683       },       \&quot;output\&quot;: \&quot;hello Alice\&quot;,       \&quot;started_at\&quot;: \&quot;2023-09-08T16:19:34.779176Z\&quot;,       \&quot;source\&quot;: \&quot;api\&quot;,       \&quot;status\&quot;: \&quot;succeeded\&quot;,       \&quot;urls\&quot;: {         \&quot;get\&quot;: \&quot;https://api.replicate.com/v1/predictions/gm3qorzdhgbfurvjtvhg6dckhu\&quot;,         \&quot;cancel\&quot;: \&quot;https://api.replicate.com/v1/predictions/gm3qorzdhgbfurvjtvhg6dckhu/cancel\&quot;       },       \&quot;model\&quot;: \&quot;replicate/hello-world\&quot;,       \&quot;version\&quot;: \&quot;5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa\&quot;,     }   ] } &#x60;&#x60;&#x60;  &#x60;id&#x60; will be the unique ID of the prediction.  &#x60;source&#x60; will indicate how the prediction was created. Possible values are &#x60;web&#x60; or &#x60;api&#x60;.  &#x60;status&#x60; will be the status of the prediction. Refer to [get a single prediction](#predictions.get) for possible values.  &#x60;urls&#x60; will be a convenience object that can be used to construct new API requests for the given prediction.  &#x60;model&#x60; will be the model identifier string in the format of &#x60;{model_owner}/{model_name}&#x60;.  &#x60;version&#x60; will be the unique ID of model version used to create the prediction. 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PredictionsListWithHttpInfo(int operationIndex = 0);
        /// <summary>
        /// Cancel a training
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trainingId">The ID of the training you want to cancel. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void TrainingsCancel(string trainingId, int operationIndex = 0);

        /// <summary>
        /// Cancel a training
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trainingId">The ID of the training you want to cancel. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> TrainingsCancelWithHttpInfo(string trainingId, int operationIndex = 0);
        /// <summary>
        /// Create a training
        /// </summary>
        /// <remarks>
        /// Start a new training of the model version you specify.  Example request body:  &#x60;&#x60;&#x60;json {   \&quot;destination\&quot;: \&quot;{new_owner}/{new_name}\&quot;,   \&quot;input\&quot;: {     \&quot;train_data\&quot;: \&quot;https://example.com/my-input-images.zip\&quot;,   },   \&quot;webhook\&quot;: \&quot;https://example.com/my-webhook\&quot;, } &#x60;&#x60;&#x60;  Example cURL request:  &#x60;&#x60;&#x60;console curl -s -X POST \\   -d &#39;{\&quot;destination\&quot;: \&quot;{new_owner}/{new_name}\&quot;, \&quot;input\&quot;: {\&quot;input_images\&quot;: \&quot;https://example.com/my-input-images.zip\&quot;}}&#39; \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   -H &#39;Content-Type: application/json&#39; \\   https://api.replicate.com/v1/models/stability-ai/sdxl/versions/da77bc59ee60423279fd632efb4795ab731d9e3ca9705ef3341091fb989b7eaf/trainings &#x60;&#x60;&#x60;  The response will be the training object:  &#x60;&#x60;&#x60;json {   \&quot;id\&quot;: \&quot;zz4ibbonubfz7carwiefibzgga\&quot;,   \&quot;model\&quot;: \&quot;stability-ai/sdxl\&quot;,   \&quot;version\&quot;: \&quot;da77bc59ee60423279fd632efb4795ab731d9e3ca9705ef3341091fb989b7eaf\&quot;,   \&quot;input\&quot;: {     \&quot;input_images\&quot;: \&quot;https://example.com/my-input-images.zip\&quot;   },   \&quot;logs\&quot;: \&quot;\&quot;,   \&quot;error\&quot;: null,   \&quot;status\&quot;: \&quot;starting\&quot;,   \&quot;created_at\&quot;: \&quot;2023-09-08T16:32:56.990893084Z\&quot;,   \&quot;urls\&quot;: {     \&quot;cancel\&quot;: \&quot;https://api.replicate.com/v1/predictions/zz4ibbonubfz7carwiefibzgga/cancel\&quot;,     \&quot;get\&quot;: \&quot;https://api.replicate.com/v1/predictions/zz4ibbonubfz7carwiefibzgga\&quot;   } } &#x60;&#x60;&#x60;  As models can take several minutes or more to train, the result will not be available immediately. To get the final result of the training you should either provide a &#x60;webhook&#x60; HTTPS URL for us to call when the results are ready, or poll the [get a training](#trainings.get) endpoint until it has finished.  When a training completes, it creates a new [version](https://replicate.com/docs/how-does-replicate-work#terminology) of the model at the specified destination.  To find some models to train on, check out the [trainable language models collection](https://replicate.com/collections/trainable-language-models). 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelOwner">The name of the user or organization that owns the model. </param>
        /// <param name="modelName">The name of the model. </param>
        /// <param name="versionId">The ID of the version. </param>
        /// <param name="trainingsCreateRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void TrainingsCreate(string modelOwner, string modelName, string versionId, TrainingsCreateRequest? trainingsCreateRequest = default(TrainingsCreateRequest?), int operationIndex = 0);

        /// <summary>
        /// Create a training
        /// </summary>
        /// <remarks>
        /// Start a new training of the model version you specify.  Example request body:  &#x60;&#x60;&#x60;json {   \&quot;destination\&quot;: \&quot;{new_owner}/{new_name}\&quot;,   \&quot;input\&quot;: {     \&quot;train_data\&quot;: \&quot;https://example.com/my-input-images.zip\&quot;,   },   \&quot;webhook\&quot;: \&quot;https://example.com/my-webhook\&quot;, } &#x60;&#x60;&#x60;  Example cURL request:  &#x60;&#x60;&#x60;console curl -s -X POST \\   -d &#39;{\&quot;destination\&quot;: \&quot;{new_owner}/{new_name}\&quot;, \&quot;input\&quot;: {\&quot;input_images\&quot;: \&quot;https://example.com/my-input-images.zip\&quot;}}&#39; \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   -H &#39;Content-Type: application/json&#39; \\   https://api.replicate.com/v1/models/stability-ai/sdxl/versions/da77bc59ee60423279fd632efb4795ab731d9e3ca9705ef3341091fb989b7eaf/trainings &#x60;&#x60;&#x60;  The response will be the training object:  &#x60;&#x60;&#x60;json {   \&quot;id\&quot;: \&quot;zz4ibbonubfz7carwiefibzgga\&quot;,   \&quot;model\&quot;: \&quot;stability-ai/sdxl\&quot;,   \&quot;version\&quot;: \&quot;da77bc59ee60423279fd632efb4795ab731d9e3ca9705ef3341091fb989b7eaf\&quot;,   \&quot;input\&quot;: {     \&quot;input_images\&quot;: \&quot;https://example.com/my-input-images.zip\&quot;   },   \&quot;logs\&quot;: \&quot;\&quot;,   \&quot;error\&quot;: null,   \&quot;status\&quot;: \&quot;starting\&quot;,   \&quot;created_at\&quot;: \&quot;2023-09-08T16:32:56.990893084Z\&quot;,   \&quot;urls\&quot;: {     \&quot;cancel\&quot;: \&quot;https://api.replicate.com/v1/predictions/zz4ibbonubfz7carwiefibzgga/cancel\&quot;,     \&quot;get\&quot;: \&quot;https://api.replicate.com/v1/predictions/zz4ibbonubfz7carwiefibzgga\&quot;   } } &#x60;&#x60;&#x60;  As models can take several minutes or more to train, the result will not be available immediately. To get the final result of the training you should either provide a &#x60;webhook&#x60; HTTPS URL for us to call when the results are ready, or poll the [get a training](#trainings.get) endpoint until it has finished.  When a training completes, it creates a new [version](https://replicate.com/docs/how-does-replicate-work#terminology) of the model at the specified destination.  To find some models to train on, check out the [trainable language models collection](https://replicate.com/collections/trainable-language-models). 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelOwner">The name of the user or organization that owns the model. </param>
        /// <param name="modelName">The name of the model. </param>
        /// <param name="versionId">The ID of the version. </param>
        /// <param name="trainingsCreateRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> TrainingsCreateWithHttpInfo(string modelOwner, string modelName, string versionId, TrainingsCreateRequest? trainingsCreateRequest = default(TrainingsCreateRequest?), int operationIndex = 0);
        /// <summary>
        /// Get a training
        /// </summary>
        /// <remarks>
        /// Get the current state of a training.  Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/trainings/zz4ibbonubfz7carwiefibzgga &#x60;&#x60;&#x60;  The response will be the training object:  &#x60;&#x60;&#x60;json {   \&quot;completed_at\&quot;: \&quot;2023-09-08T16:41:19.826523Z\&quot;,   \&quot;created_at\&quot;: \&quot;2023-09-08T16:32:57.018467Z\&quot;,   \&quot;error\&quot;: null,   \&quot;id\&quot;: \&quot;zz4ibbonubfz7carwiefibzgga\&quot;,   \&quot;input\&quot;: {     \&quot;input_images\&quot;: \&quot;https://example.com/my-input-images.zip\&quot;   },   \&quot;logs\&quot;: \&quot;...\&quot;,   \&quot;metrics\&quot;: {     \&quot;predict_time\&quot;: 502.713876   },   \&quot;output\&quot;: {     \&quot;version\&quot;: \&quot;...\&quot;,     \&quot;weights\&quot;: \&quot;...\&quot;   },   \&quot;started_at\&quot;: \&quot;2023-09-08T16:32:57.112647Z\&quot;,   \&quot;status\&quot;: \&quot;succeeded\&quot;,   \&quot;urls\&quot;: {     \&quot;get\&quot;: \&quot;https://api.replicate.com/v1/trainings/zz4ibbonubfz7carwiefibzgga\&quot;,     \&quot;cancel\&quot;: \&quot;https://api.replicate.com/v1/trainings/zz4ibbonubfz7carwiefibzgga/cancel\&quot;   },   \&quot;model\&quot;: \&quot;stability-ai/sdxl\&quot;,   \&quot;version\&quot;: \&quot;da77bc59ee60423279fd632efb4795ab731d9e3ca9705ef3341091fb989b7eaf\&quot;, } &#x60;&#x60;&#x60;  &#x60;status&#x60; will be one of:  - &#x60;starting&#x60;: the training is starting up. If this status lasts longer than a few seconds, then it&#39;s typically because a new worker is being started to run the training. - &#x60;processing&#x60;: the &#x60;train()&#x60; method of the model is currently running. - &#x60;succeeded&#x60;: the training completed successfully. - &#x60;failed&#x60;: the training encountered an error during processing. - &#x60;canceled&#x60;: the training was canceled by its creator.  In the case of success, &#x60;output&#x60; will be an object containing the output of the model. Any files will be represented as HTTPS URLs. You&#39;ll need to pass the &#x60;Authorization&#x60; header to request them.  In the case of failure, &#x60;error&#x60; will contain the error encountered during the training.  Terminated trainings (with a status of &#x60;succeeded&#x60;, &#x60;failed&#x60;, or &#x60;canceled&#x60;) will include a &#x60;metrics&#x60; object with a &#x60;predict_time&#x60; property showing the amount of CPU or GPU time, in seconds, that the training used while running. It won&#39;t include time waiting for the training to start. 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trainingId">The ID of the training to get. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void TrainingsGet(string trainingId, int operationIndex = 0);

        /// <summary>
        /// Get a training
        /// </summary>
        /// <remarks>
        /// Get the current state of a training.  Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/trainings/zz4ibbonubfz7carwiefibzgga &#x60;&#x60;&#x60;  The response will be the training object:  &#x60;&#x60;&#x60;json {   \&quot;completed_at\&quot;: \&quot;2023-09-08T16:41:19.826523Z\&quot;,   \&quot;created_at\&quot;: \&quot;2023-09-08T16:32:57.018467Z\&quot;,   \&quot;error\&quot;: null,   \&quot;id\&quot;: \&quot;zz4ibbonubfz7carwiefibzgga\&quot;,   \&quot;input\&quot;: {     \&quot;input_images\&quot;: \&quot;https://example.com/my-input-images.zip\&quot;   },   \&quot;logs\&quot;: \&quot;...\&quot;,   \&quot;metrics\&quot;: {     \&quot;predict_time\&quot;: 502.713876   },   \&quot;output\&quot;: {     \&quot;version\&quot;: \&quot;...\&quot;,     \&quot;weights\&quot;: \&quot;...\&quot;   },   \&quot;started_at\&quot;: \&quot;2023-09-08T16:32:57.112647Z\&quot;,   \&quot;status\&quot;: \&quot;succeeded\&quot;,   \&quot;urls\&quot;: {     \&quot;get\&quot;: \&quot;https://api.replicate.com/v1/trainings/zz4ibbonubfz7carwiefibzgga\&quot;,     \&quot;cancel\&quot;: \&quot;https://api.replicate.com/v1/trainings/zz4ibbonubfz7carwiefibzgga/cancel\&quot;   },   \&quot;model\&quot;: \&quot;stability-ai/sdxl\&quot;,   \&quot;version\&quot;: \&quot;da77bc59ee60423279fd632efb4795ab731d9e3ca9705ef3341091fb989b7eaf\&quot;, } &#x60;&#x60;&#x60;  &#x60;status&#x60; will be one of:  - &#x60;starting&#x60;: the training is starting up. If this status lasts longer than a few seconds, then it&#39;s typically because a new worker is being started to run the training. - &#x60;processing&#x60;: the &#x60;train()&#x60; method of the model is currently running. - &#x60;succeeded&#x60;: the training completed successfully. - &#x60;failed&#x60;: the training encountered an error during processing. - &#x60;canceled&#x60;: the training was canceled by its creator.  In the case of success, &#x60;output&#x60; will be an object containing the output of the model. Any files will be represented as HTTPS URLs. You&#39;ll need to pass the &#x60;Authorization&#x60; header to request them.  In the case of failure, &#x60;error&#x60; will contain the error encountered during the training.  Terminated trainings (with a status of &#x60;succeeded&#x60;, &#x60;failed&#x60;, or &#x60;canceled&#x60;) will include a &#x60;metrics&#x60; object with a &#x60;predict_time&#x60; property showing the amount of CPU or GPU time, in seconds, that the training used while running. It won&#39;t include time waiting for the training to start. 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trainingId">The ID of the training to get. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> TrainingsGetWithHttpInfo(string trainingId, int operationIndex = 0);
        /// <summary>
        /// List trainings
        /// </summary>
        /// <remarks>
        /// Get a paginated list of trainings that you&#39;ve created. This will include trainings created from the API and the website. It will return 100 records per page.  Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/trainings &#x60;&#x60;&#x60;  The response will be a paginated JSON array of training objects, sorted with the most recent training first:  &#x60;&#x60;&#x60;json {   \&quot;next\&quot;: null,   \&quot;previous\&quot;: null,   \&quot;results\&quot;: [     {       \&quot;completed_at\&quot;: \&quot;2023-09-08T16:41:19.826523Z\&quot;,       \&quot;created_at\&quot;: \&quot;2023-09-08T16:32:57.018467Z\&quot;,       \&quot;error\&quot;: null,       \&quot;id\&quot;: \&quot;zz4ibbonubfz7carwiefibzgga\&quot;,       \&quot;input\&quot;: {         \&quot;input_images\&quot;: \&quot;https://example.com/my-input-images.zip\&quot;       },       \&quot;metrics\&quot;: {         \&quot;predict_time\&quot;: 502.713876       },       \&quot;output\&quot;: {         \&quot;version\&quot;: \&quot;...\&quot;,         \&quot;weights\&quot;: \&quot;...\&quot;       },       \&quot;started_at\&quot;: \&quot;2023-09-08T16:32:57.112647Z\&quot;,       \&quot;source\&quot;: \&quot;api\&quot;,       \&quot;status\&quot;: \&quot;succeeded\&quot;,       \&quot;urls\&quot;: {         \&quot;get\&quot;: \&quot;https://api.replicate.com/v1/trainings/zz4ibbonubfz7carwiefibzgga\&quot;,         \&quot;cancel\&quot;: \&quot;https://api.replicate.com/v1/trainings/zz4ibbonubfz7carwiefibzgga/cancel\&quot;       },       \&quot;model\&quot;: \&quot;stability-ai/sdxl\&quot;,       \&quot;version\&quot;: \&quot;da77bc59ee60423279fd632efb4795ab731d9e3ca9705ef3341091fb989b7eaf\&quot;,     }   ] } &#x60;&#x60;&#x60;  &#x60;id&#x60; will be the unique ID of the training.  &#x60;source&#x60; will indicate how the training was created. Possible values are &#x60;web&#x60; or &#x60;api&#x60;.  &#x60;status&#x60; will be the status of the training. Refer to [get a single training](#trainings.get) for possible values.  &#x60;urls&#x60; will be a convenience object that can be used to construct new API requests for the given training.  &#x60;version&#x60; will be the unique ID of model version used to create the training. 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void TrainingsList(int operationIndex = 0);

        /// <summary>
        /// List trainings
        /// </summary>
        /// <remarks>
        /// Get a paginated list of trainings that you&#39;ve created. This will include trainings created from the API and the website. It will return 100 records per page.  Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/trainings &#x60;&#x60;&#x60;  The response will be a paginated JSON array of training objects, sorted with the most recent training first:  &#x60;&#x60;&#x60;json {   \&quot;next\&quot;: null,   \&quot;previous\&quot;: null,   \&quot;results\&quot;: [     {       \&quot;completed_at\&quot;: \&quot;2023-09-08T16:41:19.826523Z\&quot;,       \&quot;created_at\&quot;: \&quot;2023-09-08T16:32:57.018467Z\&quot;,       \&quot;error\&quot;: null,       \&quot;id\&quot;: \&quot;zz4ibbonubfz7carwiefibzgga\&quot;,       \&quot;input\&quot;: {         \&quot;input_images\&quot;: \&quot;https://example.com/my-input-images.zip\&quot;       },       \&quot;metrics\&quot;: {         \&quot;predict_time\&quot;: 502.713876       },       \&quot;output\&quot;: {         \&quot;version\&quot;: \&quot;...\&quot;,         \&quot;weights\&quot;: \&quot;...\&quot;       },       \&quot;started_at\&quot;: \&quot;2023-09-08T16:32:57.112647Z\&quot;,       \&quot;source\&quot;: \&quot;api\&quot;,       \&quot;status\&quot;: \&quot;succeeded\&quot;,       \&quot;urls\&quot;: {         \&quot;get\&quot;: \&quot;https://api.replicate.com/v1/trainings/zz4ibbonubfz7carwiefibzgga\&quot;,         \&quot;cancel\&quot;: \&quot;https://api.replicate.com/v1/trainings/zz4ibbonubfz7carwiefibzgga/cancel\&quot;       },       \&quot;model\&quot;: \&quot;stability-ai/sdxl\&quot;,       \&quot;version\&quot;: \&quot;da77bc59ee60423279fd632efb4795ab731d9e3ca9705ef3341091fb989b7eaf\&quot;,     }   ] } &#x60;&#x60;&#x60;  &#x60;id&#x60; will be the unique ID of the training.  &#x60;source&#x60; will indicate how the training was created. Possible values are &#x60;web&#x60; or &#x60;api&#x60;.  &#x60;status&#x60; will be the status of the training. Refer to [get a single training](#trainings.get) for possible values.  &#x60;urls&#x60; will be a convenience object that can be used to construct new API requests for the given training.  &#x60;version&#x60; will be the unique ID of model version used to create the training. 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> TrainingsListWithHttpInfo(int operationIndex = 0);
        /// <summary>
        /// Get the signing secret for the default webhook
        /// </summary>
        /// <remarks>
        /// Get the signing secret for the default webhook endpoint. This is used to verify that webhook requests are coming from Replicate.  Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/webhooks/default/secret &#x60;&#x60;&#x60;  The response will be a JSON object with a &#x60;key&#x60; property:  &#x60;&#x60;&#x60;json {   \&quot;key\&quot;: \&quot;...\&quot; } &#x60;&#x60;&#x60; 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>WebhooksDefaultSecretGet200Response</returns>
        WebhookResponse WebhooksDefaultSecretGet(int operationIndex = 0);

        /// <summary>
        /// Get the signing secret for the default webhook
        /// </summary>
        /// <remarks>
        /// Get the signing secret for the default webhook endpoint. This is used to verify that webhook requests are coming from Replicate.  Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/webhooks/default/secret &#x60;&#x60;&#x60;  The response will be a JSON object with a &#x60;key&#x60; property:  &#x60;&#x60;&#x60;json {   \&quot;key\&quot;: \&quot;...\&quot; } &#x60;&#x60;&#x60; 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of WebhooksDefaultSecretGet200Response</returns>
        ApiResponse<WebhookResponse> WebhooksDefaultSecretGetWithHttpInfo(int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDefaultApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get the authenticated account
        /// </summary>
        /// <remarks>
        /// Returns information about the user or organization associated with the provided API token.  Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/account &#x60;&#x60;&#x60;  The response will be a JSON object describing the account:  &#x60;&#x60;&#x60;json {   \&quot;type\&quot;: \&quot;organization\&quot;,   \&quot;username\&quot;: \&quot;acme\&quot;,   \&quot;name\&quot;: \&quot;Acme Corp, Inc.\&quot;,   \&quot;github_url\&quot;: \&quot;https://github.com/acme\&quot;, } &#x60;&#x60;&#x60; 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Account</returns>
        System.Threading.Tasks.Task<Account> AccountGetAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get the authenticated account
        /// </summary>
        /// <remarks>
        /// Returns information about the user or organization associated with the provided API token.  Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/account &#x60;&#x60;&#x60;  The response will be a JSON object describing the account:  &#x60;&#x60;&#x60;json {   \&quot;type\&quot;: \&quot;organization\&quot;,   \&quot;username\&quot;: \&quot;acme\&quot;,   \&quot;name\&quot;: \&quot;Acme Corp, Inc.\&quot;,   \&quot;github_url\&quot;: \&quot;https://github.com/acme\&quot;, } &#x60;&#x60;&#x60; 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Account)</returns>
        System.Threading.Tasks.Task<ApiResponse<Account>> AccountGetWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get a collection of models
        /// </summary>
        /// <remarks>
        /// Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/collections/super-resolution &#x60;&#x60;&#x60;  The response will be a collection object with a nested list of the models in that collection:  &#x60;&#x60;&#x60;json {   \&quot;name\&quot;: \&quot;Super resolution\&quot;,   \&quot;slug\&quot;: \&quot;super-resolution\&quot;,   \&quot;description\&quot;: \&quot;Upscaling models that create high-quality images from low-quality images.\&quot;,   \&quot;models\&quot;: [...] } &#x60;&#x60;&#x60; 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="collectionSlug">The slug of the collection, like &#x60;super-resolution&#x60; or &#x60;image-restoration&#x60;. See [replicate.com/collections](https://replicate.com/collections). </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task CollectionsGetAsync(string collectionSlug, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get a collection of models
        /// </summary>
        /// <remarks>
        /// Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/collections/super-resolution &#x60;&#x60;&#x60;  The response will be a collection object with a nested list of the models in that collection:  &#x60;&#x60;&#x60;json {   \&quot;name\&quot;: \&quot;Super resolution\&quot;,   \&quot;slug\&quot;: \&quot;super-resolution\&quot;,   \&quot;description\&quot;: \&quot;Upscaling models that create high-quality images from low-quality images.\&quot;,   \&quot;models\&quot;: [...] } &#x60;&#x60;&#x60; 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="collectionSlug">The slug of the collection, like &#x60;super-resolution&#x60; or &#x60;image-restoration&#x60;. See [replicate.com/collections](https://replicate.com/collections). </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> CollectionsGetWithHttpInfoAsync(string collectionSlug, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// List collections of models
        /// </summary>
        /// <remarks>
        /// Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/collections &#x60;&#x60;&#x60;  The response will be a paginated JSON list of collection objects:  &#x60;&#x60;&#x60;json {   \&quot;next\&quot;: \&quot;null\&quot;,   \&quot;previous\&quot;: null,   \&quot;results\&quot;: [     {       \&quot;name\&quot;: \&quot;Super resolution\&quot;,       \&quot;slug\&quot;: \&quot;super-resolution\&quot;,       \&quot;description\&quot;: \&quot;Upscaling models that create high-quality images from low-quality images.\&quot;     }   ] } &#x60;&#x60;&#x60; 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task CollectionsListAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// List collections of models
        /// </summary>
        /// <remarks>
        /// Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/collections &#x60;&#x60;&#x60;  The response will be a paginated JSON list of collection objects:  &#x60;&#x60;&#x60;json {   \&quot;next\&quot;: \&quot;null\&quot;,   \&quot;previous\&quot;: null,   \&quot;results\&quot;: [     {       \&quot;name\&quot;: \&quot;Super resolution\&quot;,       \&quot;slug\&quot;: \&quot;super-resolution\&quot;,       \&quot;description\&quot;: \&quot;Upscaling models that create high-quality images from low-quality images.\&quot;     }   ] } &#x60;&#x60;&#x60; 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> CollectionsListWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get a deployment
        /// </summary>
        /// <remarks>
        /// Get information about a deployment by name including the current release.  Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token   &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/deployments/replicate/my-app-image-generator &#x60;&#x60;&#x60;  The response will be a JSON object describing the deployment:  &#x60;&#x60;&#x60;json {   \&quot;owner\&quot;: \&quot;replicate\&quot;,   \&quot;name\&quot;: \&quot;my-app-image-generator\&quot;,   \&quot;current_release\&quot;: {     \&quot;number\&quot;: 1,     \&quot;model\&quot;: \&quot;stability-ai/sdxl\&quot;,     \&quot;version\&quot;: \&quot;da77bc59ee60423279fd632efb4795ab731d9e3ca9705ef3341091fb989b7eaf\&quot;,     \&quot;created_at\&quot;: \&quot;2024-02-15T16:32:57.018467Z\&quot;,     \&quot;created_by\&quot;: {       \&quot;type\&quot;: \&quot;organization\&quot;,       \&quot;username\&quot;: \&quot;acme\&quot;,       \&quot;name\&quot;: \&quot;Acme Corp, Inc.\&quot;,       \&quot;github_url\&quot;: \&quot;https://github.com/acme\&quot;,     },     \&quot;configuration\&quot;: {       \&quot;hardware\&quot;: \&quot;gpu-t4\&quot;,       \&quot;scaling\&quot;: {         \&quot;min_instances\&quot;: 1,         \&quot;max_instances\&quot;: 5       }     }   } } &#x60;&#x60;&#x60; 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentOwner">The name of the user or organization that owns the deployment. </param>
        /// <param name="deploymentName">The name of the deployment. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DeploymentsGet200Response</returns>
        System.Threading.Tasks.Task<Deployment> DeploymentsGetAsync(string deploymentOwner, string deploymentName, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get a deployment
        /// </summary>
        /// <remarks>
        /// Get information about a deployment by name including the current release.  Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token   &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/deployments/replicate/my-app-image-generator &#x60;&#x60;&#x60;  The response will be a JSON object describing the deployment:  &#x60;&#x60;&#x60;json {   \&quot;owner\&quot;: \&quot;replicate\&quot;,   \&quot;name\&quot;: \&quot;my-app-image-generator\&quot;,   \&quot;current_release\&quot;: {     \&quot;number\&quot;: 1,     \&quot;model\&quot;: \&quot;stability-ai/sdxl\&quot;,     \&quot;version\&quot;: \&quot;da77bc59ee60423279fd632efb4795ab731d9e3ca9705ef3341091fb989b7eaf\&quot;,     \&quot;created_at\&quot;: \&quot;2024-02-15T16:32:57.018467Z\&quot;,     \&quot;created_by\&quot;: {       \&quot;type\&quot;: \&quot;organization\&quot;,       \&quot;username\&quot;: \&quot;acme\&quot;,       \&quot;name\&quot;: \&quot;Acme Corp, Inc.\&quot;,       \&quot;github_url\&quot;: \&quot;https://github.com/acme\&quot;,     },     \&quot;configuration\&quot;: {       \&quot;hardware\&quot;: \&quot;gpu-t4\&quot;,       \&quot;scaling\&quot;: {         \&quot;min_instances\&quot;: 1,         \&quot;max_instances\&quot;: 5       }     }   } } &#x60;&#x60;&#x60; 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentOwner">The name of the user or organization that owns the deployment. </param>
        /// <param name="deploymentName">The name of the deployment. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DeploymentsGet200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<Deployment>> DeploymentsGetWithHttpInfoAsync(string deploymentOwner, string deploymentName, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// List available hardware for models
        /// </summary>
        /// <remarks>
        /// Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/hardware &#x60;&#x60;&#x60;  The response will be a JSON array of hardware objects:  &#x60;&#x60;&#x60;json [     {\&quot;name\&quot;: \&quot;CPU\&quot;, \&quot;sku\&quot;: \&quot;cpu\&quot;},     {\&quot;name\&quot;: \&quot;Nvidia T4 GPU\&quot;, \&quot;sku\&quot;: \&quot;gpu-t4\&quot;},     {\&quot;name\&quot;: \&quot;Nvidia A40 GPU\&quot;, \&quot;sku\&quot;: \&quot;gpu-a40-small\&quot;},     {\&quot;name\&quot;: \&quot;Nvidia A40 (Large) GPU\&quot;, \&quot;sku\&quot;: \&quot;gpu-a40-large\&quot;}, ] &#x60;&#x60;&#x60; 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;HardwareList200ResponseInner&gt;</returns>
        System.Threading.Tasks.Task<List<HardwareListResponse>> HardwareListAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// List available hardware for models
        /// </summary>
        /// <remarks>
        /// Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/hardware &#x60;&#x60;&#x60;  The response will be a JSON array of hardware objects:  &#x60;&#x60;&#x60;json [     {\&quot;name\&quot;: \&quot;CPU\&quot;, \&quot;sku\&quot;: \&quot;cpu\&quot;},     {\&quot;name\&quot;: \&quot;Nvidia T4 GPU\&quot;, \&quot;sku\&quot;: \&quot;gpu-t4\&quot;},     {\&quot;name\&quot;: \&quot;Nvidia A40 GPU\&quot;, \&quot;sku\&quot;: \&quot;gpu-a40-small\&quot;},     {\&quot;name\&quot;: \&quot;Nvidia A40 (Large) GPU\&quot;, \&quot;sku\&quot;: \&quot;gpu-a40-large\&quot;}, ] &#x60;&#x60;&#x60; 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;HardwareList200ResponseInner&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<HardwareListResponse>>> HardwareListWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Create a model
        /// </summary>
        /// <remarks>
        /// Create a model.  Example cURL request:  &#x60;&#x60;&#x60;console curl -s -X POST \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   -d &#39;{\&quot;owner\&quot;: \&quot;alice\&quot; \&quot;name\&quot;: \&quot;my-model\&quot;, \&quot;description\&quot;: \&quot;An example model\&quot;, \&quot;visibility\&quot;: \&quot;public\&quot;, \&quot;hardware\&quot;: \&quot;cpu\&quot;}&#39; \\   https://api.replicate.com/v1/models &#x60;&#x60;&#x60;  The response will be a model object in the following format:  &#x60;&#x60;&#x60;json {   \&quot;url\&quot;: \&quot;https://replicate.com/alice/my-model\&quot;,   \&quot;owner\&quot;: \&quot;alice\&quot;,   \&quot;name\&quot;: \&quot;my-model\&quot;,   \&quot;description\&quot;: \&quot;An example model\&quot;,   \&quot;visibility\&quot;: \&quot;public\&quot;,   \&quot;github_url\&quot;: null,   \&quot;paper_url\&quot;: null,   \&quot;license_url\&quot;: null,   \&quot;run_count\&quot;: 0,   \&quot;cover_image_url\&quot;: null,   \&quot;default_example\&quot;: null,   \&quot;latest_version\&quot;: null, } &#x60;&#x60;&#x60; 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelsCreateRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ModelsCreateAsync(ModelsCreateRequest modelsCreateRequest, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Create a model
        /// </summary>
        /// <remarks>
        /// Create a model.  Example cURL request:  &#x60;&#x60;&#x60;console curl -s -X POST \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   -d &#39;{\&quot;owner\&quot;: \&quot;alice\&quot; \&quot;name\&quot;: \&quot;my-model\&quot;, \&quot;description\&quot;: \&quot;An example model\&quot;, \&quot;visibility\&quot;: \&quot;public\&quot;, \&quot;hardware\&quot;: \&quot;cpu\&quot;}&#39; \\   https://api.replicate.com/v1/models &#x60;&#x60;&#x60;  The response will be a model object in the following format:  &#x60;&#x60;&#x60;json {   \&quot;url\&quot;: \&quot;https://replicate.com/alice/my-model\&quot;,   \&quot;owner\&quot;: \&quot;alice\&quot;,   \&quot;name\&quot;: \&quot;my-model\&quot;,   \&quot;description\&quot;: \&quot;An example model\&quot;,   \&quot;visibility\&quot;: \&quot;public\&quot;,   \&quot;github_url\&quot;: null,   \&quot;paper_url\&quot;: null,   \&quot;license_url\&quot;: null,   \&quot;run_count\&quot;: 0,   \&quot;cover_image_url\&quot;: null,   \&quot;default_example\&quot;: null,   \&quot;latest_version\&quot;: null, } &#x60;&#x60;&#x60; 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelsCreateRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ModelsCreateWithHttpInfoAsync(ModelsCreateRequest modelsCreateRequest, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get a model
        /// </summary>
        /// <remarks>
        /// Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/models/replicate/hello-world &#x60;&#x60;&#x60;  The response will be a model object in the following format:  &#x60;&#x60;&#x60;json {   \&quot;url\&quot;: \&quot;https://replicate.com/replicate/hello-world\&quot;,   \&quot;owner\&quot;: \&quot;replicate\&quot;,   \&quot;name\&quot;: \&quot;hello-world\&quot;,   \&quot;description\&quot;: \&quot;A tiny model that says hello\&quot;,   \&quot;visibility\&quot;: \&quot;public\&quot;,   \&quot;github_url\&quot;: \&quot;https://github.com/replicate/cog-examples\&quot;,   \&quot;paper_url\&quot;: null,   \&quot;license_url\&quot;: null,   \&quot;run_count\&quot;: 5681081,   \&quot;cover_image_url\&quot;: \&quot;...\&quot;,   \&quot;default_example\&quot;: {...},   \&quot;latest_version\&quot;: {...}, } &#x60;&#x60;&#x60;  The &#x60;cover_image_url&#x60; string is an HTTPS URL for an image file. This can be:  - An image uploaded by the model author. - The output file of the example prediction, if the model author has not set a cover image. - The input file of the example prediction, if the model author has not set a cover image and the example prediction has no output file. - A generic fallback image.  The &#x60;default_example&#x60; object is a [prediction](#predictions.get) created with this model.  The &#x60;latest_version&#x60; object is the model&#39;s most recently pushed [version](#models.versions.get). 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelOwner">The name of the user or organization that owns the model. </param>
        /// <param name="modelName">The name of the model. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ModelsGetAsync(string modelOwner, string modelName, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get a model
        /// </summary>
        /// <remarks>
        /// Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/models/replicate/hello-world &#x60;&#x60;&#x60;  The response will be a model object in the following format:  &#x60;&#x60;&#x60;json {   \&quot;url\&quot;: \&quot;https://replicate.com/replicate/hello-world\&quot;,   \&quot;owner\&quot;: \&quot;replicate\&quot;,   \&quot;name\&quot;: \&quot;hello-world\&quot;,   \&quot;description\&quot;: \&quot;A tiny model that says hello\&quot;,   \&quot;visibility\&quot;: \&quot;public\&quot;,   \&quot;github_url\&quot;: \&quot;https://github.com/replicate/cog-examples\&quot;,   \&quot;paper_url\&quot;: null,   \&quot;license_url\&quot;: null,   \&quot;run_count\&quot;: 5681081,   \&quot;cover_image_url\&quot;: \&quot;...\&quot;,   \&quot;default_example\&quot;: {...},   \&quot;latest_version\&quot;: {...}, } &#x60;&#x60;&#x60;  The &#x60;cover_image_url&#x60; string is an HTTPS URL for an image file. This can be:  - An image uploaded by the model author. - The output file of the example prediction, if the model author has not set a cover image. - The input file of the example prediction, if the model author has not set a cover image and the example prediction has no output file. - A generic fallback image.  The &#x60;default_example&#x60; object is a [prediction](#predictions.get) created with this model.  The &#x60;latest_version&#x60; object is the model&#39;s most recently pushed [version](#models.versions.get). 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelOwner">The name of the user or organization that owns the model. </param>
        /// <param name="modelName">The name of the model. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ModelsGetWithHttpInfoAsync(string modelOwner, string modelName, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// List public models
        /// </summary>
        /// <remarks>
        /// Get a paginated list of public models.  Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/models &#x60;&#x60;&#x60;  The response will be a paginated JSON array of model objects:  &#x60;&#x60;&#x60;json {   \&quot;next\&quot;: null,   \&quot;previous\&quot;: null,   \&quot;results\&quot;: [     {       \&quot;url\&quot;: \&quot;https://replicate.com/replicate/hello-world\&quot;,       \&quot;owner\&quot;: \&quot;replicate\&quot;,       \&quot;name\&quot;: \&quot;hello-world\&quot;,       \&quot;description\&quot;: \&quot;A tiny model that says hello\&quot;,       \&quot;visibility\&quot;: \&quot;public\&quot;,       \&quot;github_url\&quot;: \&quot;https://github.com/replicate/cog-examples\&quot;,       \&quot;paper_url\&quot;: null,       \&quot;license_url\&quot;: null,       \&quot;run_count\&quot;: 5681081,       \&quot;cover_image_url\&quot;: \&quot;...\&quot;,       \&quot;default_example\&quot;: {...},       \&quot;latest_version\&quot;: {...}     }   ] } &#x60;&#x60;&#x60;  The &#x60;cover_image_url&#x60; string is an HTTPS URL for an image file. This can be:  - An image uploaded by the model author. - The output file of the example prediction, if the model author has not set a cover image. - The input file of the example prediction, if the model author has not set a cover image and the example prediction has no output file. - A generic fallback image. 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ModelsListAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// List public models
        /// </summary>
        /// <remarks>
        /// Get a paginated list of public models.  Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/models &#x60;&#x60;&#x60;  The response will be a paginated JSON array of model objects:  &#x60;&#x60;&#x60;json {   \&quot;next\&quot;: null,   \&quot;previous\&quot;: null,   \&quot;results\&quot;: [     {       \&quot;url\&quot;: \&quot;https://replicate.com/replicate/hello-world\&quot;,       \&quot;owner\&quot;: \&quot;replicate\&quot;,       \&quot;name\&quot;: \&quot;hello-world\&quot;,       \&quot;description\&quot;: \&quot;A tiny model that says hello\&quot;,       \&quot;visibility\&quot;: \&quot;public\&quot;,       \&quot;github_url\&quot;: \&quot;https://github.com/replicate/cog-examples\&quot;,       \&quot;paper_url\&quot;: null,       \&quot;license_url\&quot;: null,       \&quot;run_count\&quot;: 5681081,       \&quot;cover_image_url\&quot;: \&quot;...\&quot;,       \&quot;default_example\&quot;: {...},       \&quot;latest_version\&quot;: {...}     }   ] } &#x60;&#x60;&#x60;  The &#x60;cover_image_url&#x60; string is an HTTPS URL for an image file. This can be:  - An image uploaded by the model author. - The output file of the example prediction, if the model author has not set a cover image. - The input file of the example prediction, if the model author has not set a cover image and the example prediction has no output file. - A generic fallback image. 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ModelsListWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Delete a model version
        /// </summary>
        /// <remarks>
        /// Delete a model version and all associated predictions, including all output files.  Model version deletion has some restrictions:  - You can only delete versions from models you own. - You can only delete versions from private models. - You cannot delete a version if someone other than you has run predictions with it.  Example cURL request:  &#x60;&#x60;&#x60;command curl -s -X DELETE \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/models/replicate/hello-world/versions/5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa &#x60;&#x60;&#x60;  The response will be an empty 202, indicating the deletion request has been accepted. It might take a few minutes to be processed. 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelOwner">The name of the user or organization that owns the model. </param>
        /// <param name="modelName">The name of the model. </param>
        /// <param name="versionId">The ID of the version. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ModelsVersionsDeleteAsync(string modelOwner, string modelName, string versionId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Delete a model version
        /// </summary>
        /// <remarks>
        /// Delete a model version and all associated predictions, including all output files.  Model version deletion has some restrictions:  - You can only delete versions from models you own. - You can only delete versions from private models. - You cannot delete a version if someone other than you has run predictions with it.  Example cURL request:  &#x60;&#x60;&#x60;command curl -s -X DELETE \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/models/replicate/hello-world/versions/5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa &#x60;&#x60;&#x60;  The response will be an empty 202, indicating the deletion request has been accepted. It might take a few minutes to be processed. 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelOwner">The name of the user or organization that owns the model. </param>
        /// <param name="modelName">The name of the model. </param>
        /// <param name="versionId">The ID of the version. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ModelsVersionsDeleteWithHttpInfoAsync(string modelOwner, string modelName, string versionId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get a model version
        /// </summary>
        /// <remarks>
        /// Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/models/replicate/hello-world/versions/5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa &#x60;&#x60;&#x60;  The response will be the version object:  &#x60;&#x60;&#x60;json {   \&quot;id\&quot;: \&quot;5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa\&quot;,   \&quot;created_at\&quot;: \&quot;2022-04-26T19:29:04.418669Z\&quot;,   \&quot;cog_version\&quot;: \&quot;0.3.0\&quot;,   \&quot;openapi_schema\&quot;: {...} } &#x60;&#x60;&#x60;  Every model describes its inputs and outputs with [OpenAPI Schema Objects](https://spec.openapis.org/oas/latest.html#schemaObject) in the &#x60;openapi_schema&#x60; property.  The &#x60;openapi_schema.components.schemas.Input&#x60; property for the [replicate/hello-world](https://replicate.com/replicate/hello-world) model looks like this:  &#x60;&#x60;&#x60;json {   \&quot;type\&quot;: \&quot;object\&quot;,   \&quot;title\&quot;: \&quot;Input\&quot;,   \&quot;required\&quot;: [     \&quot;text\&quot;   ],   \&quot;properties\&quot;: {     \&quot;text\&quot;: {       \&quot;x-order\&quot;: 0,       \&quot;type\&quot;: \&quot;string\&quot;,       \&quot;title\&quot;: \&quot;Text\&quot;,       \&quot;description\&quot;: \&quot;Text to prefix with &#39;hello &#39;\&quot;     }   } } &#x60;&#x60;&#x60;  The &#x60;openapi_schema.components.schemas.Output&#x60; property for the [replicate/hello-world](https://replicate.com/replicate/hello-world) model looks like this:  &#x60;&#x60;&#x60;json {   \&quot;type\&quot;: \&quot;string\&quot;,   \&quot;title\&quot;: \&quot;Output\&quot; } &#x60;&#x60;&#x60;  For more details, see the docs on [Cog&#39;s supported input and output types](https://github.com/replicate/cog/blob/75b7802219e7cd4cee845e34c4c22139558615d4/docs/python.md#input-and-output-types) 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelOwner">The name of the user or organization that owns the model. </param>
        /// <param name="modelName">The name of the model. </param>
        /// <param name="versionId">The ID of the version. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ModelsVersionsGetAsync(string modelOwner, string modelName, string versionId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get a model version
        /// </summary>
        /// <remarks>
        /// Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/models/replicate/hello-world/versions/5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa &#x60;&#x60;&#x60;  The response will be the version object:  &#x60;&#x60;&#x60;json {   \&quot;id\&quot;: \&quot;5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa\&quot;,   \&quot;created_at\&quot;: \&quot;2022-04-26T19:29:04.418669Z\&quot;,   \&quot;cog_version\&quot;: \&quot;0.3.0\&quot;,   \&quot;openapi_schema\&quot;: {...} } &#x60;&#x60;&#x60;  Every model describes its inputs and outputs with [OpenAPI Schema Objects](https://spec.openapis.org/oas/latest.html#schemaObject) in the &#x60;openapi_schema&#x60; property.  The &#x60;openapi_schema.components.schemas.Input&#x60; property for the [replicate/hello-world](https://replicate.com/replicate/hello-world) model looks like this:  &#x60;&#x60;&#x60;json {   \&quot;type\&quot;: \&quot;object\&quot;,   \&quot;title\&quot;: \&quot;Input\&quot;,   \&quot;required\&quot;: [     \&quot;text\&quot;   ],   \&quot;properties\&quot;: {     \&quot;text\&quot;: {       \&quot;x-order\&quot;: 0,       \&quot;type\&quot;: \&quot;string\&quot;,       \&quot;title\&quot;: \&quot;Text\&quot;,       \&quot;description\&quot;: \&quot;Text to prefix with &#39;hello &#39;\&quot;     }   } } &#x60;&#x60;&#x60;  The &#x60;openapi_schema.components.schemas.Output&#x60; property for the [replicate/hello-world](https://replicate.com/replicate/hello-world) model looks like this:  &#x60;&#x60;&#x60;json {   \&quot;type\&quot;: \&quot;string\&quot;,   \&quot;title\&quot;: \&quot;Output\&quot; } &#x60;&#x60;&#x60;  For more details, see the docs on [Cog&#39;s supported input and output types](https://github.com/replicate/cog/blob/75b7802219e7cd4cee845e34c4c22139558615d4/docs/python.md#input-and-output-types) 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelOwner">The name of the user or organization that owns the model. </param>
        /// <param name="modelName">The name of the model. </param>
        /// <param name="versionId">The ID of the version. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ModelsVersionsGetWithHttpInfoAsync(string modelOwner, string modelName, string versionId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// List model versions
        /// </summary>
        /// <remarks>
        /// Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/models/replicate/hello-world/versions &#x60;&#x60;&#x60;  The response will be a JSON array of model version objects, sorted with the most recent version first:  &#x60;&#x60;&#x60;json {   \&quot;next\&quot;: null,   \&quot;previous\&quot;: null,   \&quot;results\&quot;: [     {       \&quot;id\&quot;: \&quot;5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa\&quot;,       \&quot;created_at\&quot;: \&quot;2022-04-26T19:29:04.418669Z\&quot;,       \&quot;cog_version\&quot;: \&quot;0.3.0\&quot;,       \&quot;openapi_schema\&quot;: {...}     }   ] } &#x60;&#x60;&#x60; 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelOwner">The name of the user or organization that owns the model. </param>
        /// <param name="modelName">The name of the model. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ModelsVersionsListAsync(string modelOwner, string modelName, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// List model versions
        /// </summary>
        /// <remarks>
        /// Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/models/replicate/hello-world/versions &#x60;&#x60;&#x60;  The response will be a JSON array of model version objects, sorted with the most recent version first:  &#x60;&#x60;&#x60;json {   \&quot;next\&quot;: null,   \&quot;previous\&quot;: null,   \&quot;results\&quot;: [     {       \&quot;id\&quot;: \&quot;5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa\&quot;,       \&quot;created_at\&quot;: \&quot;2022-04-26T19:29:04.418669Z\&quot;,       \&quot;cog_version\&quot;: \&quot;0.3.0\&quot;,       \&quot;openapi_schema\&quot;: {...}     }   ] } &#x60;&#x60;&#x60; 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelOwner">The name of the user or organization that owns the model. </param>
        /// <param name="modelName">The name of the model. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ModelsVersionsListWithHttpInfoAsync(string modelOwner, string modelName, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Cancel a prediction
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="predictionId">The ID of the prediction to cancel. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PredictionsCancelAsync(string predictionId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Cancel a prediction
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="predictionId">The ID of the prediction to cancel. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PredictionsCancelWithHttpInfoAsync(string predictionId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Create a prediction
        /// </summary>
        /// <remarks>
        /// Start a new prediction for the model version and inputs you provide.  Example request body:  &#x60;&#x60;&#x60;json {   \&quot;version\&quot;: \&quot;5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa\&quot;,   \&quot;input\&quot;: {     \&quot;text\&quot;: \&quot;Alice\&quot;   } } &#x60;&#x60;&#x60;  Example cURL request:  &#x60;&#x60;&#x60;console curl -s -X POST \\   -d &#39;{\&quot;version\&quot;: \&quot;5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa\&quot;, \&quot;input\&quot;: {\&quot;text\&quot;: \&quot;Alice\&quot;}}&#39; \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   -H &#39;Content-Type: application/json&#39; \\   https://api.replicate.com/v1/predictions &#x60;&#x60;&#x60;  The response will be the prediction object:  &#x60;&#x60;&#x60;json {   \&quot;id\&quot;: \&quot;gm3qorzdhgbfurvjtvhg6dckhu\&quot;,   \&quot;model\&quot;: \&quot;replicate/hello-world\&quot;,   \&quot;version\&quot;: \&quot;5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa\&quot;,   \&quot;input\&quot;: {     \&quot;text\&quot;: \&quot;Alice\&quot;   },   \&quot;logs\&quot;: \&quot;\&quot;,   \&quot;error\&quot;: null,   \&quot;status\&quot;: \&quot;starting\&quot;,   \&quot;created_at\&quot;: \&quot;2023-09-08T16:19:34.765994657Z\&quot;,   \&quot;urls\&quot;: {     \&quot;cancel\&quot;: \&quot;https://api.replicate.com/v1/predictions/gm3qorzdhgbfurvjtvhg6dckhu/cancel\&quot;,     \&quot;get\&quot;: \&quot;https://api.replicate.com/v1/predictions/gm3qorzdhgbfurvjtvhg6dckhu\&quot;   } } &#x60;&#x60;&#x60;  As models can take several seconds or more to run, the output will not be available immediately. To get the final result of the prediction you should either provide a &#x60;webhook&#x60; HTTPS URL for us to call when the results are ready, or poll the [get a prediction](#predictions.get) endpoint until it has finished.  Input and output (including any files) will be automatically deleted after an hour, so you must save a copy of any files in the output if you&#39;d like to continue using them.  Output files are served by &#x60;replicate.delivery&#x60; and its subdomains. If you use an allow list of external domains for your assets, add &#x60;replicate.delivery&#x60; and &#x60;*.replicate.delivery&#x60; to it. 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="predictionsCreateRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PredictionsCreateAsync(PredictionsCreateRequest? predictionsCreateRequest = default(PredictionsCreateRequest?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Create a prediction
        /// </summary>
        /// <remarks>
        /// Start a new prediction for the model version and inputs you provide.  Example request body:  &#x60;&#x60;&#x60;json {   \&quot;version\&quot;: \&quot;5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa\&quot;,   \&quot;input\&quot;: {     \&quot;text\&quot;: \&quot;Alice\&quot;   } } &#x60;&#x60;&#x60;  Example cURL request:  &#x60;&#x60;&#x60;console curl -s -X POST \\   -d &#39;{\&quot;version\&quot;: \&quot;5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa\&quot;, \&quot;input\&quot;: {\&quot;text\&quot;: \&quot;Alice\&quot;}}&#39; \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   -H &#39;Content-Type: application/json&#39; \\   https://api.replicate.com/v1/predictions &#x60;&#x60;&#x60;  The response will be the prediction object:  &#x60;&#x60;&#x60;json {   \&quot;id\&quot;: \&quot;gm3qorzdhgbfurvjtvhg6dckhu\&quot;,   \&quot;model\&quot;: \&quot;replicate/hello-world\&quot;,   \&quot;version\&quot;: \&quot;5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa\&quot;,   \&quot;input\&quot;: {     \&quot;text\&quot;: \&quot;Alice\&quot;   },   \&quot;logs\&quot;: \&quot;\&quot;,   \&quot;error\&quot;: null,   \&quot;status\&quot;: \&quot;starting\&quot;,   \&quot;created_at\&quot;: \&quot;2023-09-08T16:19:34.765994657Z\&quot;,   \&quot;urls\&quot;: {     \&quot;cancel\&quot;: \&quot;https://api.replicate.com/v1/predictions/gm3qorzdhgbfurvjtvhg6dckhu/cancel\&quot;,     \&quot;get\&quot;: \&quot;https://api.replicate.com/v1/predictions/gm3qorzdhgbfurvjtvhg6dckhu\&quot;   } } &#x60;&#x60;&#x60;  As models can take several seconds or more to run, the output will not be available immediately. To get the final result of the prediction you should either provide a &#x60;webhook&#x60; HTTPS URL for us to call when the results are ready, or poll the [get a prediction](#predictions.get) endpoint until it has finished.  Input and output (including any files) will be automatically deleted after an hour, so you must save a copy of any files in the output if you&#39;d like to continue using them.  Output files are served by &#x60;replicate.delivery&#x60; and its subdomains. If you use an allow list of external domains for your assets, add &#x60;replicate.delivery&#x60; and &#x60;*.replicate.delivery&#x60; to it. 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="predictionsCreateRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PredictionsCreateWithHttpInfoAsync(PredictionsCreateRequest? predictionsCreateRequest = default(PredictionsCreateRequest?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get a prediction
        /// </summary>
        /// <remarks>
        /// Get the current state of a prediction.  Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/predictions/gm3qorzdhgbfurvjtvhg6dckhu &#x60;&#x60;&#x60;  The response will be the prediction object:  &#x60;&#x60;&#x60;json {   \&quot;id\&quot;: \&quot;gm3qorzdhgbfurvjtvhg6dckhu\&quot;,   \&quot;model\&quot;: \&quot;replicate/hello-world\&quot;,   \&quot;version\&quot;: \&quot;5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa\&quot;,   \&quot;input\&quot;: {     \&quot;text\&quot;: \&quot;Alice\&quot;   },   \&quot;logs\&quot;: \&quot;\&quot;,   \&quot;output\&quot;: \&quot;hello Alice\&quot;,   \&quot;error\&quot;: null,   \&quot;status\&quot;: \&quot;succeeded\&quot;,   \&quot;created_at\&quot;: \&quot;2023-09-08T16:19:34.765994Z\&quot;,   \&quot;started_at\&quot;: \&quot;2023-09-08T16:19:34.779176Z\&quot;,   \&quot;completed_at\&quot;: \&quot;2023-09-08T16:19:34.791859Z\&quot;,   \&quot;metrics\&quot;: {     \&quot;predict_time\&quot;: 0.012683   },   \&quot;urls\&quot;: {     \&quot;cancel\&quot;: \&quot;https://api.replicate.com/v1/predictions/gm3qorzdhgbfurvjtvhg6dckhu/cancel\&quot;,     \&quot;get\&quot;: \&quot;https://api.replicate.com/v1/predictions/gm3qorzdhgbfurvjtvhg6dckhu\&quot;   } } &#x60;&#x60;&#x60;  &#x60;status&#x60; will be one of:  - &#x60;starting&#x60;: the prediction is starting up. If this status lasts longer than a few seconds, then it&#39;s typically because a new worker is being started to run the prediction. - &#x60;processing&#x60;: the &#x60;predict()&#x60; method of the model is currently running. - &#x60;succeeded&#x60;: the prediction completed successfully. - &#x60;failed&#x60;: the prediction encountered an error during processing. - &#x60;canceled&#x60;: the prediction was canceled by its creator.  In the case of success, &#x60;output&#x60; will be an object containing the output of the model. Any files will be represented as HTTPS URLs. You&#39;ll need to pass the &#x60;Authorization&#x60; header to request them.  In the case of failure, &#x60;error&#x60; will contain the error encountered during the prediction.  Terminated predictions (with a status of &#x60;succeeded&#x60;, &#x60;failed&#x60;, or &#x60;canceled&#x60;) will include a &#x60;metrics&#x60; object with a &#x60;predict_time&#x60; property showing the amount of CPU or GPU time, in seconds, that the prediction used while running. It won&#39;t include time waiting for the prediction to start.  Input and output (including any files) are automatically deleted after an hour, so you must save a copy of any files in the output if you&#39;d like to continue using them.  Output files are served by &#x60;replicate.delivery&#x60; and its subdomains. If you use an allow list of external domains for your assets, add &#x60;replicate.delivery&#x60; and &#x60;*.replicate.delivery&#x60; to it. 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="predictionId">The ID of the prediction to get. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PredictionsGetAsync(string predictionId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get a prediction
        /// </summary>
        /// <remarks>
        /// Get the current state of a prediction.  Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/predictions/gm3qorzdhgbfurvjtvhg6dckhu &#x60;&#x60;&#x60;  The response will be the prediction object:  &#x60;&#x60;&#x60;json {   \&quot;id\&quot;: \&quot;gm3qorzdhgbfurvjtvhg6dckhu\&quot;,   \&quot;model\&quot;: \&quot;replicate/hello-world\&quot;,   \&quot;version\&quot;: \&quot;5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa\&quot;,   \&quot;input\&quot;: {     \&quot;text\&quot;: \&quot;Alice\&quot;   },   \&quot;logs\&quot;: \&quot;\&quot;,   \&quot;output\&quot;: \&quot;hello Alice\&quot;,   \&quot;error\&quot;: null,   \&quot;status\&quot;: \&quot;succeeded\&quot;,   \&quot;created_at\&quot;: \&quot;2023-09-08T16:19:34.765994Z\&quot;,   \&quot;started_at\&quot;: \&quot;2023-09-08T16:19:34.779176Z\&quot;,   \&quot;completed_at\&quot;: \&quot;2023-09-08T16:19:34.791859Z\&quot;,   \&quot;metrics\&quot;: {     \&quot;predict_time\&quot;: 0.012683   },   \&quot;urls\&quot;: {     \&quot;cancel\&quot;: \&quot;https://api.replicate.com/v1/predictions/gm3qorzdhgbfurvjtvhg6dckhu/cancel\&quot;,     \&quot;get\&quot;: \&quot;https://api.replicate.com/v1/predictions/gm3qorzdhgbfurvjtvhg6dckhu\&quot;   } } &#x60;&#x60;&#x60;  &#x60;status&#x60; will be one of:  - &#x60;starting&#x60;: the prediction is starting up. If this status lasts longer than a few seconds, then it&#39;s typically because a new worker is being started to run the prediction. - &#x60;processing&#x60;: the &#x60;predict()&#x60; method of the model is currently running. - &#x60;succeeded&#x60;: the prediction completed successfully. - &#x60;failed&#x60;: the prediction encountered an error during processing. - &#x60;canceled&#x60;: the prediction was canceled by its creator.  In the case of success, &#x60;output&#x60; will be an object containing the output of the model. Any files will be represented as HTTPS URLs. You&#39;ll need to pass the &#x60;Authorization&#x60; header to request them.  In the case of failure, &#x60;error&#x60; will contain the error encountered during the prediction.  Terminated predictions (with a status of &#x60;succeeded&#x60;, &#x60;failed&#x60;, or &#x60;canceled&#x60;) will include a &#x60;metrics&#x60; object with a &#x60;predict_time&#x60; property showing the amount of CPU or GPU time, in seconds, that the prediction used while running. It won&#39;t include time waiting for the prediction to start.  Input and output (including any files) are automatically deleted after an hour, so you must save a copy of any files in the output if you&#39;d like to continue using them.  Output files are served by &#x60;replicate.delivery&#x60; and its subdomains. If you use an allow list of external domains for your assets, add &#x60;replicate.delivery&#x60; and &#x60;*.replicate.delivery&#x60; to it. 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="predictionId">The ID of the prediction to get. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PredictionsGetWithHttpInfoAsync(string predictionId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// List predictions
        /// </summary>
        /// <remarks>
        /// Get a paginated list of predictions that you&#39;ve created. This will include predictions created from the API and the website. It will return 100 records per page.  Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/predictions &#x60;&#x60;&#x60;  The response will be a paginated JSON array of prediction objects, sorted with the most recent prediction first:  &#x60;&#x60;&#x60;json {   \&quot;next\&quot;: null,   \&quot;previous\&quot;: null,   \&quot;results\&quot;: [     {       \&quot;completed_at\&quot;: \&quot;2023-09-08T16:19:34.791859Z\&quot;,       \&quot;created_at\&quot;: \&quot;2023-09-08T16:19:34.907244Z\&quot;,       \&quot;error\&quot;: null,       \&quot;id\&quot;: \&quot;gm3qorzdhgbfurvjtvhg6dckhu\&quot;,       \&quot;input\&quot;: {         \&quot;text\&quot;: \&quot;Alice\&quot;       },       \&quot;metrics\&quot;: {         \&quot;predict_time\&quot;: 0.012683       },       \&quot;output\&quot;: \&quot;hello Alice\&quot;,       \&quot;started_at\&quot;: \&quot;2023-09-08T16:19:34.779176Z\&quot;,       \&quot;source\&quot;: \&quot;api\&quot;,       \&quot;status\&quot;: \&quot;succeeded\&quot;,       \&quot;urls\&quot;: {         \&quot;get\&quot;: \&quot;https://api.replicate.com/v1/predictions/gm3qorzdhgbfurvjtvhg6dckhu\&quot;,         \&quot;cancel\&quot;: \&quot;https://api.replicate.com/v1/predictions/gm3qorzdhgbfurvjtvhg6dckhu/cancel\&quot;       },       \&quot;model\&quot;: \&quot;replicate/hello-world\&quot;,       \&quot;version\&quot;: \&quot;5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa\&quot;,     }   ] } &#x60;&#x60;&#x60;  &#x60;id&#x60; will be the unique ID of the prediction.  &#x60;source&#x60; will indicate how the prediction was created. Possible values are &#x60;web&#x60; or &#x60;api&#x60;.  &#x60;status&#x60; will be the status of the prediction. Refer to [get a single prediction](#predictions.get) for possible values.  &#x60;urls&#x60; will be a convenience object that can be used to construct new API requests for the given prediction.  &#x60;model&#x60; will be the model identifier string in the format of &#x60;{model_owner}/{model_name}&#x60;.  &#x60;version&#x60; will be the unique ID of model version used to create the prediction. 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PredictionsListAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// List predictions
        /// </summary>
        /// <remarks>
        /// Get a paginated list of predictions that you&#39;ve created. This will include predictions created from the API and the website. It will return 100 records per page.  Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/predictions &#x60;&#x60;&#x60;  The response will be a paginated JSON array of prediction objects, sorted with the most recent prediction first:  &#x60;&#x60;&#x60;json {   \&quot;next\&quot;: null,   \&quot;previous\&quot;: null,   \&quot;results\&quot;: [     {       \&quot;completed_at\&quot;: \&quot;2023-09-08T16:19:34.791859Z\&quot;,       \&quot;created_at\&quot;: \&quot;2023-09-08T16:19:34.907244Z\&quot;,       \&quot;error\&quot;: null,       \&quot;id\&quot;: \&quot;gm3qorzdhgbfurvjtvhg6dckhu\&quot;,       \&quot;input\&quot;: {         \&quot;text\&quot;: \&quot;Alice\&quot;       },       \&quot;metrics\&quot;: {         \&quot;predict_time\&quot;: 0.012683       },       \&quot;output\&quot;: \&quot;hello Alice\&quot;,       \&quot;started_at\&quot;: \&quot;2023-09-08T16:19:34.779176Z\&quot;,       \&quot;source\&quot;: \&quot;api\&quot;,       \&quot;status\&quot;: \&quot;succeeded\&quot;,       \&quot;urls\&quot;: {         \&quot;get\&quot;: \&quot;https://api.replicate.com/v1/predictions/gm3qorzdhgbfurvjtvhg6dckhu\&quot;,         \&quot;cancel\&quot;: \&quot;https://api.replicate.com/v1/predictions/gm3qorzdhgbfurvjtvhg6dckhu/cancel\&quot;       },       \&quot;model\&quot;: \&quot;replicate/hello-world\&quot;,       \&quot;version\&quot;: \&quot;5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa\&quot;,     }   ] } &#x60;&#x60;&#x60;  &#x60;id&#x60; will be the unique ID of the prediction.  &#x60;source&#x60; will indicate how the prediction was created. Possible values are &#x60;web&#x60; or &#x60;api&#x60;.  &#x60;status&#x60; will be the status of the prediction. Refer to [get a single prediction](#predictions.get) for possible values.  &#x60;urls&#x60; will be a convenience object that can be used to construct new API requests for the given prediction.  &#x60;model&#x60; will be the model identifier string in the format of &#x60;{model_owner}/{model_name}&#x60;.  &#x60;version&#x60; will be the unique ID of model version used to create the prediction. 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PredictionsListWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Cancel a training
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trainingId">The ID of the training you want to cancel. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task TrainingsCancelAsync(string trainingId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Cancel a training
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trainingId">The ID of the training you want to cancel. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> TrainingsCancelWithHttpInfoAsync(string trainingId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Create a training
        /// </summary>
        /// <remarks>
        /// Start a new training of the model version you specify.  Example request body:  &#x60;&#x60;&#x60;json {   \&quot;destination\&quot;: \&quot;{new_owner}/{new_name}\&quot;,   \&quot;input\&quot;: {     \&quot;train_data\&quot;: \&quot;https://example.com/my-input-images.zip\&quot;,   },   \&quot;webhook\&quot;: \&quot;https://example.com/my-webhook\&quot;, } &#x60;&#x60;&#x60;  Example cURL request:  &#x60;&#x60;&#x60;console curl -s -X POST \\   -d &#39;{\&quot;destination\&quot;: \&quot;{new_owner}/{new_name}\&quot;, \&quot;input\&quot;: {\&quot;input_images\&quot;: \&quot;https://example.com/my-input-images.zip\&quot;}}&#39; \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   -H &#39;Content-Type: application/json&#39; \\   https://api.replicate.com/v1/models/stability-ai/sdxl/versions/da77bc59ee60423279fd632efb4795ab731d9e3ca9705ef3341091fb989b7eaf/trainings &#x60;&#x60;&#x60;  The response will be the training object:  &#x60;&#x60;&#x60;json {   \&quot;id\&quot;: \&quot;zz4ibbonubfz7carwiefibzgga\&quot;,   \&quot;model\&quot;: \&quot;stability-ai/sdxl\&quot;,   \&quot;version\&quot;: \&quot;da77bc59ee60423279fd632efb4795ab731d9e3ca9705ef3341091fb989b7eaf\&quot;,   \&quot;input\&quot;: {     \&quot;input_images\&quot;: \&quot;https://example.com/my-input-images.zip\&quot;   },   \&quot;logs\&quot;: \&quot;\&quot;,   \&quot;error\&quot;: null,   \&quot;status\&quot;: \&quot;starting\&quot;,   \&quot;created_at\&quot;: \&quot;2023-09-08T16:32:56.990893084Z\&quot;,   \&quot;urls\&quot;: {     \&quot;cancel\&quot;: \&quot;https://api.replicate.com/v1/predictions/zz4ibbonubfz7carwiefibzgga/cancel\&quot;,     \&quot;get\&quot;: \&quot;https://api.replicate.com/v1/predictions/zz4ibbonubfz7carwiefibzgga\&quot;   } } &#x60;&#x60;&#x60;  As models can take several minutes or more to train, the result will not be available immediately. To get the final result of the training you should either provide a &#x60;webhook&#x60; HTTPS URL for us to call when the results are ready, or poll the [get a training](#trainings.get) endpoint until it has finished.  When a training completes, it creates a new [version](https://replicate.com/docs/how-does-replicate-work#terminology) of the model at the specified destination.  To find some models to train on, check out the [trainable language models collection](https://replicate.com/collections/trainable-language-models). 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelOwner">The name of the user or organization that owns the model. </param>
        /// <param name="modelName">The name of the model. </param>
        /// <param name="versionId">The ID of the version. </param>
        /// <param name="trainingsCreateRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task TrainingsCreateAsync(string modelOwner, string modelName, string versionId, TrainingsCreateRequest? trainingsCreateRequest = default(TrainingsCreateRequest?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Create a training
        /// </summary>
        /// <remarks>
        /// Start a new training of the model version you specify.  Example request body:  &#x60;&#x60;&#x60;json {   \&quot;destination\&quot;: \&quot;{new_owner}/{new_name}\&quot;,   \&quot;input\&quot;: {     \&quot;train_data\&quot;: \&quot;https://example.com/my-input-images.zip\&quot;,   },   \&quot;webhook\&quot;: \&quot;https://example.com/my-webhook\&quot;, } &#x60;&#x60;&#x60;  Example cURL request:  &#x60;&#x60;&#x60;console curl -s -X POST \\   -d &#39;{\&quot;destination\&quot;: \&quot;{new_owner}/{new_name}\&quot;, \&quot;input\&quot;: {\&quot;input_images\&quot;: \&quot;https://example.com/my-input-images.zip\&quot;}}&#39; \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   -H &#39;Content-Type: application/json&#39; \\   https://api.replicate.com/v1/models/stability-ai/sdxl/versions/da77bc59ee60423279fd632efb4795ab731d9e3ca9705ef3341091fb989b7eaf/trainings &#x60;&#x60;&#x60;  The response will be the training object:  &#x60;&#x60;&#x60;json {   \&quot;id\&quot;: \&quot;zz4ibbonubfz7carwiefibzgga\&quot;,   \&quot;model\&quot;: \&quot;stability-ai/sdxl\&quot;,   \&quot;version\&quot;: \&quot;da77bc59ee60423279fd632efb4795ab731d9e3ca9705ef3341091fb989b7eaf\&quot;,   \&quot;input\&quot;: {     \&quot;input_images\&quot;: \&quot;https://example.com/my-input-images.zip\&quot;   },   \&quot;logs\&quot;: \&quot;\&quot;,   \&quot;error\&quot;: null,   \&quot;status\&quot;: \&quot;starting\&quot;,   \&quot;created_at\&quot;: \&quot;2023-09-08T16:32:56.990893084Z\&quot;,   \&quot;urls\&quot;: {     \&quot;cancel\&quot;: \&quot;https://api.replicate.com/v1/predictions/zz4ibbonubfz7carwiefibzgga/cancel\&quot;,     \&quot;get\&quot;: \&quot;https://api.replicate.com/v1/predictions/zz4ibbonubfz7carwiefibzgga\&quot;   } } &#x60;&#x60;&#x60;  As models can take several minutes or more to train, the result will not be available immediately. To get the final result of the training you should either provide a &#x60;webhook&#x60; HTTPS URL for us to call when the results are ready, or poll the [get a training](#trainings.get) endpoint until it has finished.  When a training completes, it creates a new [version](https://replicate.com/docs/how-does-replicate-work#terminology) of the model at the specified destination.  To find some models to train on, check out the [trainable language models collection](https://replicate.com/collections/trainable-language-models). 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelOwner">The name of the user or organization that owns the model. </param>
        /// <param name="modelName">The name of the model. </param>
        /// <param name="versionId">The ID of the version. </param>
        /// <param name="trainingsCreateRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> TrainingsCreateWithHttpInfoAsync(string modelOwner, string modelName, string versionId, TrainingsCreateRequest? trainingsCreateRequest = default(TrainingsCreateRequest?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get a training
        /// </summary>
        /// <remarks>
        /// Get the current state of a training.  Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/trainings/zz4ibbonubfz7carwiefibzgga &#x60;&#x60;&#x60;  The response will be the training object:  &#x60;&#x60;&#x60;json {   \&quot;completed_at\&quot;: \&quot;2023-09-08T16:41:19.826523Z\&quot;,   \&quot;created_at\&quot;: \&quot;2023-09-08T16:32:57.018467Z\&quot;,   \&quot;error\&quot;: null,   \&quot;id\&quot;: \&quot;zz4ibbonubfz7carwiefibzgga\&quot;,   \&quot;input\&quot;: {     \&quot;input_images\&quot;: \&quot;https://example.com/my-input-images.zip\&quot;   },   \&quot;logs\&quot;: \&quot;...\&quot;,   \&quot;metrics\&quot;: {     \&quot;predict_time\&quot;: 502.713876   },   \&quot;output\&quot;: {     \&quot;version\&quot;: \&quot;...\&quot;,     \&quot;weights\&quot;: \&quot;...\&quot;   },   \&quot;started_at\&quot;: \&quot;2023-09-08T16:32:57.112647Z\&quot;,   \&quot;status\&quot;: \&quot;succeeded\&quot;,   \&quot;urls\&quot;: {     \&quot;get\&quot;: \&quot;https://api.replicate.com/v1/trainings/zz4ibbonubfz7carwiefibzgga\&quot;,     \&quot;cancel\&quot;: \&quot;https://api.replicate.com/v1/trainings/zz4ibbonubfz7carwiefibzgga/cancel\&quot;   },   \&quot;model\&quot;: \&quot;stability-ai/sdxl\&quot;,   \&quot;version\&quot;: \&quot;da77bc59ee60423279fd632efb4795ab731d9e3ca9705ef3341091fb989b7eaf\&quot;, } &#x60;&#x60;&#x60;  &#x60;status&#x60; will be one of:  - &#x60;starting&#x60;: the training is starting up. If this status lasts longer than a few seconds, then it&#39;s typically because a new worker is being started to run the training. - &#x60;processing&#x60;: the &#x60;train()&#x60; method of the model is currently running. - &#x60;succeeded&#x60;: the training completed successfully. - &#x60;failed&#x60;: the training encountered an error during processing. - &#x60;canceled&#x60;: the training was canceled by its creator.  In the case of success, &#x60;output&#x60; will be an object containing the output of the model. Any files will be represented as HTTPS URLs. You&#39;ll need to pass the &#x60;Authorization&#x60; header to request them.  In the case of failure, &#x60;error&#x60; will contain the error encountered during the training.  Terminated trainings (with a status of &#x60;succeeded&#x60;, &#x60;failed&#x60;, or &#x60;canceled&#x60;) will include a &#x60;metrics&#x60; object with a &#x60;predict_time&#x60; property showing the amount of CPU or GPU time, in seconds, that the training used while running. It won&#39;t include time waiting for the training to start. 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trainingId">The ID of the training to get. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task TrainingsGetAsync(string trainingId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get a training
        /// </summary>
        /// <remarks>
        /// Get the current state of a training.  Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/trainings/zz4ibbonubfz7carwiefibzgga &#x60;&#x60;&#x60;  The response will be the training object:  &#x60;&#x60;&#x60;json {   \&quot;completed_at\&quot;: \&quot;2023-09-08T16:41:19.826523Z\&quot;,   \&quot;created_at\&quot;: \&quot;2023-09-08T16:32:57.018467Z\&quot;,   \&quot;error\&quot;: null,   \&quot;id\&quot;: \&quot;zz4ibbonubfz7carwiefibzgga\&quot;,   \&quot;input\&quot;: {     \&quot;input_images\&quot;: \&quot;https://example.com/my-input-images.zip\&quot;   },   \&quot;logs\&quot;: \&quot;...\&quot;,   \&quot;metrics\&quot;: {     \&quot;predict_time\&quot;: 502.713876   },   \&quot;output\&quot;: {     \&quot;version\&quot;: \&quot;...\&quot;,     \&quot;weights\&quot;: \&quot;...\&quot;   },   \&quot;started_at\&quot;: \&quot;2023-09-08T16:32:57.112647Z\&quot;,   \&quot;status\&quot;: \&quot;succeeded\&quot;,   \&quot;urls\&quot;: {     \&quot;get\&quot;: \&quot;https://api.replicate.com/v1/trainings/zz4ibbonubfz7carwiefibzgga\&quot;,     \&quot;cancel\&quot;: \&quot;https://api.replicate.com/v1/trainings/zz4ibbonubfz7carwiefibzgga/cancel\&quot;   },   \&quot;model\&quot;: \&quot;stability-ai/sdxl\&quot;,   \&quot;version\&quot;: \&quot;da77bc59ee60423279fd632efb4795ab731d9e3ca9705ef3341091fb989b7eaf\&quot;, } &#x60;&#x60;&#x60;  &#x60;status&#x60; will be one of:  - &#x60;starting&#x60;: the training is starting up. If this status lasts longer than a few seconds, then it&#39;s typically because a new worker is being started to run the training. - &#x60;processing&#x60;: the &#x60;train()&#x60; method of the model is currently running. - &#x60;succeeded&#x60;: the training completed successfully. - &#x60;failed&#x60;: the training encountered an error during processing. - &#x60;canceled&#x60;: the training was canceled by its creator.  In the case of success, &#x60;output&#x60; will be an object containing the output of the model. Any files will be represented as HTTPS URLs. You&#39;ll need to pass the &#x60;Authorization&#x60; header to request them.  In the case of failure, &#x60;error&#x60; will contain the error encountered during the training.  Terminated trainings (with a status of &#x60;succeeded&#x60;, &#x60;failed&#x60;, or &#x60;canceled&#x60;) will include a &#x60;metrics&#x60; object with a &#x60;predict_time&#x60; property showing the amount of CPU or GPU time, in seconds, that the training used while running. It won&#39;t include time waiting for the training to start. 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trainingId">The ID of the training to get. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> TrainingsGetWithHttpInfoAsync(string trainingId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// List trainings
        /// </summary>
        /// <remarks>
        /// Get a paginated list of trainings that you&#39;ve created. This will include trainings created from the API and the website. It will return 100 records per page.  Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/trainings &#x60;&#x60;&#x60;  The response will be a paginated JSON array of training objects, sorted with the most recent training first:  &#x60;&#x60;&#x60;json {   \&quot;next\&quot;: null,   \&quot;previous\&quot;: null,   \&quot;results\&quot;: [     {       \&quot;completed_at\&quot;: \&quot;2023-09-08T16:41:19.826523Z\&quot;,       \&quot;created_at\&quot;: \&quot;2023-09-08T16:32:57.018467Z\&quot;,       \&quot;error\&quot;: null,       \&quot;id\&quot;: \&quot;zz4ibbonubfz7carwiefibzgga\&quot;,       \&quot;input\&quot;: {         \&quot;input_images\&quot;: \&quot;https://example.com/my-input-images.zip\&quot;       },       \&quot;metrics\&quot;: {         \&quot;predict_time\&quot;: 502.713876       },       \&quot;output\&quot;: {         \&quot;version\&quot;: \&quot;...\&quot;,         \&quot;weights\&quot;: \&quot;...\&quot;       },       \&quot;started_at\&quot;: \&quot;2023-09-08T16:32:57.112647Z\&quot;,       \&quot;source\&quot;: \&quot;api\&quot;,       \&quot;status\&quot;: \&quot;succeeded\&quot;,       \&quot;urls\&quot;: {         \&quot;get\&quot;: \&quot;https://api.replicate.com/v1/trainings/zz4ibbonubfz7carwiefibzgga\&quot;,         \&quot;cancel\&quot;: \&quot;https://api.replicate.com/v1/trainings/zz4ibbonubfz7carwiefibzgga/cancel\&quot;       },       \&quot;model\&quot;: \&quot;stability-ai/sdxl\&quot;,       \&quot;version\&quot;: \&quot;da77bc59ee60423279fd632efb4795ab731d9e3ca9705ef3341091fb989b7eaf\&quot;,     }   ] } &#x60;&#x60;&#x60;  &#x60;id&#x60; will be the unique ID of the training.  &#x60;source&#x60; will indicate how the training was created. Possible values are &#x60;web&#x60; or &#x60;api&#x60;.  &#x60;status&#x60; will be the status of the training. Refer to [get a single training](#trainings.get) for possible values.  &#x60;urls&#x60; will be a convenience object that can be used to construct new API requests for the given training.  &#x60;version&#x60; will be the unique ID of model version used to create the training. 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task TrainingsListAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// List trainings
        /// </summary>
        /// <remarks>
        /// Get a paginated list of trainings that you&#39;ve created. This will include trainings created from the API and the website. It will return 100 records per page.  Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/trainings &#x60;&#x60;&#x60;  The response will be a paginated JSON array of training objects, sorted with the most recent training first:  &#x60;&#x60;&#x60;json {   \&quot;next\&quot;: null,   \&quot;previous\&quot;: null,   \&quot;results\&quot;: [     {       \&quot;completed_at\&quot;: \&quot;2023-09-08T16:41:19.826523Z\&quot;,       \&quot;created_at\&quot;: \&quot;2023-09-08T16:32:57.018467Z\&quot;,       \&quot;error\&quot;: null,       \&quot;id\&quot;: \&quot;zz4ibbonubfz7carwiefibzgga\&quot;,       \&quot;input\&quot;: {         \&quot;input_images\&quot;: \&quot;https://example.com/my-input-images.zip\&quot;       },       \&quot;metrics\&quot;: {         \&quot;predict_time\&quot;: 502.713876       },       \&quot;output\&quot;: {         \&quot;version\&quot;: \&quot;...\&quot;,         \&quot;weights\&quot;: \&quot;...\&quot;       },       \&quot;started_at\&quot;: \&quot;2023-09-08T16:32:57.112647Z\&quot;,       \&quot;source\&quot;: \&quot;api\&quot;,       \&quot;status\&quot;: \&quot;succeeded\&quot;,       \&quot;urls\&quot;: {         \&quot;get\&quot;: \&quot;https://api.replicate.com/v1/trainings/zz4ibbonubfz7carwiefibzgga\&quot;,         \&quot;cancel\&quot;: \&quot;https://api.replicate.com/v1/trainings/zz4ibbonubfz7carwiefibzgga/cancel\&quot;       },       \&quot;model\&quot;: \&quot;stability-ai/sdxl\&quot;,       \&quot;version\&quot;: \&quot;da77bc59ee60423279fd632efb4795ab731d9e3ca9705ef3341091fb989b7eaf\&quot;,     }   ] } &#x60;&#x60;&#x60;  &#x60;id&#x60; will be the unique ID of the training.  &#x60;source&#x60; will indicate how the training was created. Possible values are &#x60;web&#x60; or &#x60;api&#x60;.  &#x60;status&#x60; will be the status of the training. Refer to [get a single training](#trainings.get) for possible values.  &#x60;urls&#x60; will be a convenience object that can be used to construct new API requests for the given training.  &#x60;version&#x60; will be the unique ID of model version used to create the training. 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> TrainingsListWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get the signing secret for the default webhook
        /// </summary>
        /// <remarks>
        /// Get the signing secret for the default webhook endpoint. This is used to verify that webhook requests are coming from Replicate.  Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/webhooks/default/secret &#x60;&#x60;&#x60;  The response will be a JSON object with a &#x60;key&#x60; property:  &#x60;&#x60;&#x60;json {   \&quot;key\&quot;: \&quot;...\&quot; } &#x60;&#x60;&#x60; 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of WebhooksDefaultSecretGet200Response</returns>
        System.Threading.Tasks.Task<WebhookResponse> WebhooksDefaultSecretGetAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get the signing secret for the default webhook
        /// </summary>
        /// <remarks>
        /// Get the signing secret for the default webhook endpoint. This is used to verify that webhook requests are coming from Replicate.  Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/webhooks/default/secret &#x60;&#x60;&#x60;  The response will be a JSON object with a &#x60;key&#x60; property:  &#x60;&#x60;&#x60;json {   \&quot;key\&quot;: \&quot;...\&quot; } &#x60;&#x60;&#x60; 
        /// </remarks>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (WebhooksDefaultSecretGet200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<WebhookResponse>> WebhooksDefaultSecretGetWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDefaultApi : IDefaultApiSync, IDefaultApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class DefaultApi : IDefaultApi
    {
        private dotnetReplicate.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DefaultApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DefaultApi(string basePath)
        {
            this.Configuration = dotnetReplicate.Client.Configuration.MergeConfigurations(
                dotnetReplicate.Client.GlobalConfiguration.Instance,
                new dotnetReplicate.Client.Configuration { BasePath = basePath }
            );
            this.Client = new dotnetReplicate.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new dotnetReplicate.Client.ApiClientAsync(this.Configuration.BasePath);
            this.ExceptionFactory = dotnetReplicate.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DefaultApi(dotnetReplicate.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = dotnetReplicate.Client.Configuration.MergeConfigurations(
                dotnetReplicate.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new dotnetReplicate.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new dotnetReplicate.Client.ApiClientAsync(this.Configuration.BasePath);
            ExceptionFactory = dotnetReplicate.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public DefaultApi(dotnetReplicate.Client.ISynchronousClient client, dotnetReplicate.Client.IAsynchronousClient asyncClient, dotnetReplicate.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = dotnetReplicate.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public dotnetReplicate.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public dotnetReplicate.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public dotnetReplicate.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public dotnetReplicate.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Get the authenticated account Returns information about the user or organization associated with the provided API token.  Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/account &#x60;&#x60;&#x60;  The response will be a JSON object describing the account:  &#x60;&#x60;&#x60;json {   \&quot;type\&quot;: \&quot;organization\&quot;,   \&quot;username\&quot;: \&quot;acme\&quot;,   \&quot;name\&quot;: \&quot;Acme Corp, Inc.\&quot;,   \&quot;github_url\&quot;: \&quot;https://github.com/acme\&quot;, } &#x60;&#x60;&#x60; 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Account</returns>
        public Account AccountGet(int operationIndex = 0)
        {
            dotnetReplicate.Client.ApiResponse<Account> localVarResponse = AccountGetWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the authenticated account Returns information about the user or organization associated with the provided API token.  Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/account &#x60;&#x60;&#x60;  The response will be a JSON object describing the account:  &#x60;&#x60;&#x60;json {   \&quot;type\&quot;: \&quot;organization\&quot;,   \&quot;username\&quot;: \&quot;acme\&quot;,   \&quot;name\&quot;: \&quot;Acme Corp, Inc.\&quot;,   \&quot;github_url\&quot;: \&quot;https://github.com/acme\&quot;, } &#x60;&#x60;&#x60; 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Account</returns>
        public dotnetReplicate.Client.ApiResponse<Account> AccountGetWithHttpInfo(int operationIndex = 0)
        {
            dotnetReplicate.Client.RequestOptions localVarRequestOptions = new dotnetReplicate.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = dotnetReplicate.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = dotnetReplicate.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }


            localVarRequestOptions.Operation = "DefaultApi.AccountGet";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Get<Account>("/account", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AccountGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the authenticated account Returns information about the user or organization associated with the provided API token.  Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/account &#x60;&#x60;&#x60;  The response will be a JSON object describing the account:  &#x60;&#x60;&#x60;json {   \&quot;type\&quot;: \&quot;organization\&quot;,   \&quot;username\&quot;: \&quot;acme\&quot;,   \&quot;name\&quot;: \&quot;Acme Corp, Inc.\&quot;,   \&quot;github_url\&quot;: \&quot;https://github.com/acme\&quot;, } &#x60;&#x60;&#x60; 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Account</returns>
        public async System.Threading.Tasks.Task<Account> AccountGetAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            dotnetReplicate.Client.ApiResponse<Account> localVarResponse = await AccountGetWithHttpInfoAsync(operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the authenticated account Returns information about the user or organization associated with the provided API token.  Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/account &#x60;&#x60;&#x60;  The response will be a JSON object describing the account:  &#x60;&#x60;&#x60;json {   \&quot;type\&quot;: \&quot;organization\&quot;,   \&quot;username\&quot;: \&quot;acme\&quot;,   \&quot;name\&quot;: \&quot;Acme Corp, Inc.\&quot;,   \&quot;github_url\&quot;: \&quot;https://github.com/acme\&quot;, } &#x60;&#x60;&#x60; 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Account)</returns>
        public async System.Threading.Tasks.Task<dotnetReplicate.Client.ApiResponse<Account>> AccountGetWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            dotnetReplicate.Client.RequestOptions localVarRequestOptions = new dotnetReplicate.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = dotnetReplicate.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = dotnetReplicate.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }


            localVarRequestOptions.Operation = "DefaultApi.AccountGet";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<Account>("/account", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AccountGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a collection of models Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/collections/super-resolution &#x60;&#x60;&#x60;  The response will be a collection object with a nested list of the models in that collection:  &#x60;&#x60;&#x60;json {   \&quot;name\&quot;: \&quot;Super resolution\&quot;,   \&quot;slug\&quot;: \&quot;super-resolution\&quot;,   \&quot;description\&quot;: \&quot;Upscaling models that create high-quality images from low-quality images.\&quot;,   \&quot;models\&quot;: [...] } &#x60;&#x60;&#x60; 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="collectionSlug">The slug of the collection, like &#x60;super-resolution&#x60; or &#x60;image-restoration&#x60;. See [replicate.com/collections](https://replicate.com/collections). </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void CollectionsGet(string collectionSlug, int operationIndex = 0)
        {
            CollectionsGetWithHttpInfo(collectionSlug);
        }

        /// <summary>
        /// Get a collection of models Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/collections/super-resolution &#x60;&#x60;&#x60;  The response will be a collection object with a nested list of the models in that collection:  &#x60;&#x60;&#x60;json {   \&quot;name\&quot;: \&quot;Super resolution\&quot;,   \&quot;slug\&quot;: \&quot;super-resolution\&quot;,   \&quot;description\&quot;: \&quot;Upscaling models that create high-quality images from low-quality images.\&quot;,   \&quot;models\&quot;: [...] } &#x60;&#x60;&#x60; 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="collectionSlug">The slug of the collection, like &#x60;super-resolution&#x60; or &#x60;image-restoration&#x60;. See [replicate.com/collections](https://replicate.com/collections). </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public dotnetReplicate.Client.ApiResponse<Object> CollectionsGetWithHttpInfo(string collectionSlug, int operationIndex = 0)
        {
            // verify the required parameter 'collectionSlug' is set
            if (collectionSlug == null)
            {
                throw new dotnetReplicate.Client.ApiException(400, "Missing required parameter 'collectionSlug' when calling DefaultApi->CollectionsGet");
            }

            dotnetReplicate.Client.RequestOptions localVarRequestOptions = new dotnetReplicate.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };

            var localVarContentType = dotnetReplicate.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = dotnetReplicate.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("collection_slug", dotnetReplicate.Client.ClientUtils.ParameterToString(collectionSlug)); // path parameter

            localVarRequestOptions.Operation = "DefaultApi.CollectionsGet";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Get<Object>("/collections/{collection_slug}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CollectionsGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a collection of models Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/collections/super-resolution &#x60;&#x60;&#x60;  The response will be a collection object with a nested list of the models in that collection:  &#x60;&#x60;&#x60;json {   \&quot;name\&quot;: \&quot;Super resolution\&quot;,   \&quot;slug\&quot;: \&quot;super-resolution\&quot;,   \&quot;description\&quot;: \&quot;Upscaling models that create high-quality images from low-quality images.\&quot;,   \&quot;models\&quot;: [...] } &#x60;&#x60;&#x60; 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="collectionSlug">The slug of the collection, like &#x60;super-resolution&#x60; or &#x60;image-restoration&#x60;. See [replicate.com/collections](https://replicate.com/collections). </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task CollectionsGetAsync(string collectionSlug, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await CollectionsGetWithHttpInfoAsync(collectionSlug, operationIndex, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a collection of models Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/collections/super-resolution &#x60;&#x60;&#x60;  The response will be a collection object with a nested list of the models in that collection:  &#x60;&#x60;&#x60;json {   \&quot;name\&quot;: \&quot;Super resolution\&quot;,   \&quot;slug\&quot;: \&quot;super-resolution\&quot;,   \&quot;description\&quot;: \&quot;Upscaling models that create high-quality images from low-quality images.\&quot;,   \&quot;models\&quot;: [...] } &#x60;&#x60;&#x60; 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="collectionSlug">The slug of the collection, like &#x60;super-resolution&#x60; or &#x60;image-restoration&#x60;. See [replicate.com/collections](https://replicate.com/collections). </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<dotnetReplicate.Client.ApiResponse<Object>> CollectionsGetWithHttpInfoAsync(string collectionSlug, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'collectionSlug' is set
            if (collectionSlug == null)
            {
                throw new dotnetReplicate.Client.ApiException(400, "Missing required parameter 'collectionSlug' when calling DefaultApi->CollectionsGet");
            }


            dotnetReplicate.Client.RequestOptions localVarRequestOptions = new dotnetReplicate.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };

            var localVarContentType = dotnetReplicate.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = dotnetReplicate.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("collection_slug", dotnetReplicate.Client.ClientUtils.ParameterToString(collectionSlug)); // path parameter

            localVarRequestOptions.Operation = "DefaultApi.CollectionsGet";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<Object>("/collections/{collection_slug}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CollectionsGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// List collections of models Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/collections &#x60;&#x60;&#x60;  The response will be a paginated JSON list of collection objects:  &#x60;&#x60;&#x60;json {   \&quot;next\&quot;: \&quot;null\&quot;,   \&quot;previous\&quot;: null,   \&quot;results\&quot;: [     {       \&quot;name\&quot;: \&quot;Super resolution\&quot;,       \&quot;slug\&quot;: \&quot;super-resolution\&quot;,       \&quot;description\&quot;: \&quot;Upscaling models that create high-quality images from low-quality images.\&quot;     }   ] } &#x60;&#x60;&#x60; 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void CollectionsList(int operationIndex = 0)
        {
            CollectionsListWithHttpInfo();
        }

        /// <summary>
        /// List collections of models Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/collections &#x60;&#x60;&#x60;  The response will be a paginated JSON list of collection objects:  &#x60;&#x60;&#x60;json {   \&quot;next\&quot;: \&quot;null\&quot;,   \&quot;previous\&quot;: null,   \&quot;results\&quot;: [     {       \&quot;name\&quot;: \&quot;Super resolution\&quot;,       \&quot;slug\&quot;: \&quot;super-resolution\&quot;,       \&quot;description\&quot;: \&quot;Upscaling models that create high-quality images from low-quality images.\&quot;     }   ] } &#x60;&#x60;&#x60; 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public dotnetReplicate.Client.ApiResponse<Object> CollectionsListWithHttpInfo(int operationIndex = 0)
        {
            dotnetReplicate.Client.RequestOptions localVarRequestOptions = new dotnetReplicate.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };

            var localVarContentType = dotnetReplicate.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = dotnetReplicate.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }


            localVarRequestOptions.Operation = "DefaultApi.CollectionsList";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Get<Object>("/collections", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CollectionsList", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// List collections of models Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/collections &#x60;&#x60;&#x60;  The response will be a paginated JSON list of collection objects:  &#x60;&#x60;&#x60;json {   \&quot;next\&quot;: \&quot;null\&quot;,   \&quot;previous\&quot;: null,   \&quot;results\&quot;: [     {       \&quot;name\&quot;: \&quot;Super resolution\&quot;,       \&quot;slug\&quot;: \&quot;super-resolution\&quot;,       \&quot;description\&quot;: \&quot;Upscaling models that create high-quality images from low-quality images.\&quot;     }   ] } &#x60;&#x60;&#x60; 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task CollectionsListAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await CollectionsListWithHttpInfoAsync(operationIndex, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// List collections of models Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/collections &#x60;&#x60;&#x60;  The response will be a paginated JSON list of collection objects:  &#x60;&#x60;&#x60;json {   \&quot;next\&quot;: \&quot;null\&quot;,   \&quot;previous\&quot;: null,   \&quot;results\&quot;: [     {       \&quot;name\&quot;: \&quot;Super resolution\&quot;,       \&quot;slug\&quot;: \&quot;super-resolution\&quot;,       \&quot;description\&quot;: \&quot;Upscaling models that create high-quality images from low-quality images.\&quot;     }   ] } &#x60;&#x60;&#x60; 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<dotnetReplicate.Client.ApiResponse<Object>> CollectionsListWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            dotnetReplicate.Client.RequestOptions localVarRequestOptions = new dotnetReplicate.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };

            var localVarContentType = dotnetReplicate.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = dotnetReplicate.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }


            localVarRequestOptions.Operation = "DefaultApi.CollectionsList";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<Object>("/collections", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CollectionsList", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a deployment Get information about a deployment by name including the current release.  Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token   &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/deployments/replicate/my-app-image-generator &#x60;&#x60;&#x60;  The response will be a JSON object describing the deployment:  &#x60;&#x60;&#x60;json {   \&quot;owner\&quot;: \&quot;replicate\&quot;,   \&quot;name\&quot;: \&quot;my-app-image-generator\&quot;,   \&quot;current_release\&quot;: {     \&quot;number\&quot;: 1,     \&quot;model\&quot;: \&quot;stability-ai/sdxl\&quot;,     \&quot;version\&quot;: \&quot;da77bc59ee60423279fd632efb4795ab731d9e3ca9705ef3341091fb989b7eaf\&quot;,     \&quot;created_at\&quot;: \&quot;2024-02-15T16:32:57.018467Z\&quot;,     \&quot;created_by\&quot;: {       \&quot;type\&quot;: \&quot;organization\&quot;,       \&quot;username\&quot;: \&quot;acme\&quot;,       \&quot;name\&quot;: \&quot;Acme Corp, Inc.\&quot;,       \&quot;github_url\&quot;: \&quot;https://github.com/acme\&quot;,     },     \&quot;configuration\&quot;: {       \&quot;hardware\&quot;: \&quot;gpu-t4\&quot;,       \&quot;scaling\&quot;: {         \&quot;min_instances\&quot;: 1,         \&quot;max_instances\&quot;: 5       }     }   } } &#x60;&#x60;&#x60; 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentOwner">The name of the user or organization that owns the deployment. </param>
        /// <param name="deploymentName">The name of the deployment. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>DeploymentsGet200Response</returns>
        public Deployment DeploymentsGet(string deploymentOwner, string deploymentName, int operationIndex = 0)
        {
            dotnetReplicate.Client.ApiResponse<Deployment> localVarResponse = DeploymentsGetWithHttpInfo(deploymentOwner, deploymentName);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a deployment Get information about a deployment by name including the current release.  Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token   &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/deployments/replicate/my-app-image-generator &#x60;&#x60;&#x60;  The response will be a JSON object describing the deployment:  &#x60;&#x60;&#x60;json {   \&quot;owner\&quot;: \&quot;replicate\&quot;,   \&quot;name\&quot;: \&quot;my-app-image-generator\&quot;,   \&quot;current_release\&quot;: {     \&quot;number\&quot;: 1,     \&quot;model\&quot;: \&quot;stability-ai/sdxl\&quot;,     \&quot;version\&quot;: \&quot;da77bc59ee60423279fd632efb4795ab731d9e3ca9705ef3341091fb989b7eaf\&quot;,     \&quot;created_at\&quot;: \&quot;2024-02-15T16:32:57.018467Z\&quot;,     \&quot;created_by\&quot;: {       \&quot;type\&quot;: \&quot;organization\&quot;,       \&quot;username\&quot;: \&quot;acme\&quot;,       \&quot;name\&quot;: \&quot;Acme Corp, Inc.\&quot;,       \&quot;github_url\&quot;: \&quot;https://github.com/acme\&quot;,     },     \&quot;configuration\&quot;: {       \&quot;hardware\&quot;: \&quot;gpu-t4\&quot;,       \&quot;scaling\&quot;: {         \&quot;min_instances\&quot;: 1,         \&quot;max_instances\&quot;: 5       }     }   } } &#x60;&#x60;&#x60; 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentOwner">The name of the user or organization that owns the deployment. </param>
        /// <param name="deploymentName">The name of the deployment. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of DeploymentsGet200Response</returns>
        public dotnetReplicate.Client.ApiResponse<Deployment> DeploymentsGetWithHttpInfo(string deploymentOwner, string deploymentName, int operationIndex = 0)
        {
            // verify the required parameter 'deploymentOwner' is set
            if (deploymentOwner == null)
            {
                throw new dotnetReplicate.Client.ApiException(400, "Missing required parameter 'deploymentOwner' when calling DefaultApi->DeploymentsGet");
            }

            // verify the required parameter 'deploymentName' is set
            if (deploymentName == null)
            {
                throw new dotnetReplicate.Client.ApiException(400, "Missing required parameter 'deploymentName' when calling DefaultApi->DeploymentsGet");
            }

            dotnetReplicate.Client.RequestOptions localVarRequestOptions = new dotnetReplicate.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = dotnetReplicate.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = dotnetReplicate.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("deployment_owner", dotnetReplicate.Client.ClientUtils.ParameterToString(deploymentOwner)); // path parameter
            localVarRequestOptions.PathParameters.Add("deployment_name", dotnetReplicate.Client.ClientUtils.ParameterToString(deploymentName)); // path parameter

            localVarRequestOptions.Operation = "DefaultApi.DeploymentsGet";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Get<Deployment>("/deployments/{deployment_owner}/{deployment_name}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeploymentsGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a deployment Get information about a deployment by name including the current release.  Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token   &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/deployments/replicate/my-app-image-generator &#x60;&#x60;&#x60;  The response will be a JSON object describing the deployment:  &#x60;&#x60;&#x60;json {   \&quot;owner\&quot;: \&quot;replicate\&quot;,   \&quot;name\&quot;: \&quot;my-app-image-generator\&quot;,   \&quot;current_release\&quot;: {     \&quot;number\&quot;: 1,     \&quot;model\&quot;: \&quot;stability-ai/sdxl\&quot;,     \&quot;version\&quot;: \&quot;da77bc59ee60423279fd632efb4795ab731d9e3ca9705ef3341091fb989b7eaf\&quot;,     \&quot;created_at\&quot;: \&quot;2024-02-15T16:32:57.018467Z\&quot;,     \&quot;created_by\&quot;: {       \&quot;type\&quot;: \&quot;organization\&quot;,       \&quot;username\&quot;: \&quot;acme\&quot;,       \&quot;name\&quot;: \&quot;Acme Corp, Inc.\&quot;,       \&quot;github_url\&quot;: \&quot;https://github.com/acme\&quot;,     },     \&quot;configuration\&quot;: {       \&quot;hardware\&quot;: \&quot;gpu-t4\&quot;,       \&quot;scaling\&quot;: {         \&quot;min_instances\&quot;: 1,         \&quot;max_instances\&quot;: 5       }     }   } } &#x60;&#x60;&#x60; 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentOwner">The name of the user or organization that owns the deployment. </param>
        /// <param name="deploymentName">The name of the deployment. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DeploymentsGet200Response</returns>
        public async System.Threading.Tasks.Task<Deployment> DeploymentsGetAsync(string deploymentOwner, string deploymentName, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            dotnetReplicate.Client.ApiResponse<Deployment> localVarResponse = await DeploymentsGetWithHttpInfoAsync(deploymentOwner, deploymentName, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a deployment Get information about a deployment by name including the current release.  Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token   &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/deployments/replicate/my-app-image-generator &#x60;&#x60;&#x60;  The response will be a JSON object describing the deployment:  &#x60;&#x60;&#x60;json {   \&quot;owner\&quot;: \&quot;replicate\&quot;,   \&quot;name\&quot;: \&quot;my-app-image-generator\&quot;,   \&quot;current_release\&quot;: {     \&quot;number\&quot;: 1,     \&quot;model\&quot;: \&quot;stability-ai/sdxl\&quot;,     \&quot;version\&quot;: \&quot;da77bc59ee60423279fd632efb4795ab731d9e3ca9705ef3341091fb989b7eaf\&quot;,     \&quot;created_at\&quot;: \&quot;2024-02-15T16:32:57.018467Z\&quot;,     \&quot;created_by\&quot;: {       \&quot;type\&quot;: \&quot;organization\&quot;,       \&quot;username\&quot;: \&quot;acme\&quot;,       \&quot;name\&quot;: \&quot;Acme Corp, Inc.\&quot;,       \&quot;github_url\&quot;: \&quot;https://github.com/acme\&quot;,     },     \&quot;configuration\&quot;: {       \&quot;hardware\&quot;: \&quot;gpu-t4\&quot;,       \&quot;scaling\&quot;: {         \&quot;min_instances\&quot;: 1,         \&quot;max_instances\&quot;: 5       }     }   } } &#x60;&#x60;&#x60; 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentOwner">The name of the user or organization that owns the deployment. </param>
        /// <param name="deploymentName">The name of the deployment. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DeploymentsGet200Response)</returns>
        public async System.Threading.Tasks.Task<dotnetReplicate.Client.ApiResponse<Deployment>> DeploymentsGetWithHttpInfoAsync(string deploymentOwner, string deploymentName, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'deploymentOwner' is set
            if (deploymentOwner == null)
            {
                throw new dotnetReplicate.Client.ApiException(400, "Missing required parameter 'deploymentOwner' when calling DefaultApi->DeploymentsGet");
            }

            // verify the required parameter 'deploymentName' is set
            if (deploymentName == null)
            {
                throw new dotnetReplicate.Client.ApiException(400, "Missing required parameter 'deploymentName' when calling DefaultApi->DeploymentsGet");
            }


            dotnetReplicate.Client.RequestOptions localVarRequestOptions = new dotnetReplicate.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = dotnetReplicate.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = dotnetReplicate.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("deployment_owner", dotnetReplicate.Client.ClientUtils.ParameterToString(deploymentOwner)); // path parameter
            localVarRequestOptions.PathParameters.Add("deployment_name", dotnetReplicate.Client.ClientUtils.ParameterToString(deploymentName)); // path parameter

            localVarRequestOptions.Operation = "DefaultApi.DeploymentsGet";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<Deployment>("/deployments/{deployment_owner}/{deployment_name}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeploymentsGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// List available hardware for models Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/hardware &#x60;&#x60;&#x60;  The response will be a JSON array of hardware objects:  &#x60;&#x60;&#x60;json [     {\&quot;name\&quot;: \&quot;CPU\&quot;, \&quot;sku\&quot;: \&quot;cpu\&quot;},     {\&quot;name\&quot;: \&quot;Nvidia T4 GPU\&quot;, \&quot;sku\&quot;: \&quot;gpu-t4\&quot;},     {\&quot;name\&quot;: \&quot;Nvidia A40 GPU\&quot;, \&quot;sku\&quot;: \&quot;gpu-a40-small\&quot;},     {\&quot;name\&quot;: \&quot;Nvidia A40 (Large) GPU\&quot;, \&quot;sku\&quot;: \&quot;gpu-a40-large\&quot;}, ] &#x60;&#x60;&#x60; 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;HardwareList200ResponseInner&gt;</returns>
        public List<HardwareListResponse> HardwareList(int operationIndex = 0)
        {
            dotnetReplicate.Client.ApiResponse<List<HardwareListResponse>> localVarResponse = HardwareListWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// List available hardware for models Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/hardware &#x60;&#x60;&#x60;  The response will be a JSON array of hardware objects:  &#x60;&#x60;&#x60;json [     {\&quot;name\&quot;: \&quot;CPU\&quot;, \&quot;sku\&quot;: \&quot;cpu\&quot;},     {\&quot;name\&quot;: \&quot;Nvidia T4 GPU\&quot;, \&quot;sku\&quot;: \&quot;gpu-t4\&quot;},     {\&quot;name\&quot;: \&quot;Nvidia A40 GPU\&quot;, \&quot;sku\&quot;: \&quot;gpu-a40-small\&quot;},     {\&quot;name\&quot;: \&quot;Nvidia A40 (Large) GPU\&quot;, \&quot;sku\&quot;: \&quot;gpu-a40-large\&quot;}, ] &#x60;&#x60;&#x60; 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;HardwareList200ResponseInner&gt;</returns>
        public dotnetReplicate.Client.ApiResponse<List<HardwareListResponse>> HardwareListWithHttpInfo(int operationIndex = 0)
        {
            dotnetReplicate.Client.RequestOptions localVarRequestOptions = new dotnetReplicate.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = dotnetReplicate.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = dotnetReplicate.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }


            localVarRequestOptions.Operation = "DefaultApi.HardwareList";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Get<List<HardwareListResponse>>("/hardware", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HardwareList", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// List available hardware for models Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/hardware &#x60;&#x60;&#x60;  The response will be a JSON array of hardware objects:  &#x60;&#x60;&#x60;json [     {\&quot;name\&quot;: \&quot;CPU\&quot;, \&quot;sku\&quot;: \&quot;cpu\&quot;},     {\&quot;name\&quot;: \&quot;Nvidia T4 GPU\&quot;, \&quot;sku\&quot;: \&quot;gpu-t4\&quot;},     {\&quot;name\&quot;: \&quot;Nvidia A40 GPU\&quot;, \&quot;sku\&quot;: \&quot;gpu-a40-small\&quot;},     {\&quot;name\&quot;: \&quot;Nvidia A40 (Large) GPU\&quot;, \&quot;sku\&quot;: \&quot;gpu-a40-large\&quot;}, ] &#x60;&#x60;&#x60; 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;HardwareList200ResponseInner&gt;</returns>
        public async System.Threading.Tasks.Task<List<HardwareListResponse>> HardwareListAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            dotnetReplicate.Client.ApiResponse<List<HardwareListResponse>> localVarResponse = await HardwareListWithHttpInfoAsync(operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List available hardware for models Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/hardware &#x60;&#x60;&#x60;  The response will be a JSON array of hardware objects:  &#x60;&#x60;&#x60;json [     {\&quot;name\&quot;: \&quot;CPU\&quot;, \&quot;sku\&quot;: \&quot;cpu\&quot;},     {\&quot;name\&quot;: \&quot;Nvidia T4 GPU\&quot;, \&quot;sku\&quot;: \&quot;gpu-t4\&quot;},     {\&quot;name\&quot;: \&quot;Nvidia A40 GPU\&quot;, \&quot;sku\&quot;: \&quot;gpu-a40-small\&quot;},     {\&quot;name\&quot;: \&quot;Nvidia A40 (Large) GPU\&quot;, \&quot;sku\&quot;: \&quot;gpu-a40-large\&quot;}, ] &#x60;&#x60;&#x60; 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;HardwareList200ResponseInner&gt;)</returns>
        public async System.Threading.Tasks.Task<dotnetReplicate.Client.ApiResponse<List<HardwareListResponse>>> HardwareListWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            dotnetReplicate.Client.RequestOptions localVarRequestOptions = new dotnetReplicate.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = dotnetReplicate.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = dotnetReplicate.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }


            localVarRequestOptions.Operation = "DefaultApi.HardwareList";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<List<HardwareListResponse>>("/hardware", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HardwareList", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create a model Create a model.  Example cURL request:  &#x60;&#x60;&#x60;console curl -s -X POST \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   -d &#39;{\&quot;owner\&quot;: \&quot;alice\&quot; \&quot;name\&quot;: \&quot;my-model\&quot;, \&quot;description\&quot;: \&quot;An example model\&quot;, \&quot;visibility\&quot;: \&quot;public\&quot;, \&quot;hardware\&quot;: \&quot;cpu\&quot;}&#39; \\   https://api.replicate.com/v1/models &#x60;&#x60;&#x60;  The response will be a model object in the following format:  &#x60;&#x60;&#x60;json {   \&quot;url\&quot;: \&quot;https://replicate.com/alice/my-model\&quot;,   \&quot;owner\&quot;: \&quot;alice\&quot;,   \&quot;name\&quot;: \&quot;my-model\&quot;,   \&quot;description\&quot;: \&quot;An example model\&quot;,   \&quot;visibility\&quot;: \&quot;public\&quot;,   \&quot;github_url\&quot;: null,   \&quot;paper_url\&quot;: null,   \&quot;license_url\&quot;: null,   \&quot;run_count\&quot;: 0,   \&quot;cover_image_url\&quot;: null,   \&quot;default_example\&quot;: null,   \&quot;latest_version\&quot;: null, } &#x60;&#x60;&#x60; 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelsCreateRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void ModelsCreate(ModelsCreateRequest modelsCreateRequest, int operationIndex = 0)
        {
            ModelsCreateWithHttpInfo(modelsCreateRequest);
        }

        /// <summary>
        /// Create a model Create a model.  Example cURL request:  &#x60;&#x60;&#x60;console curl -s -X POST \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   -d &#39;{\&quot;owner\&quot;: \&quot;alice\&quot; \&quot;name\&quot;: \&quot;my-model\&quot;, \&quot;description\&quot;: \&quot;An example model\&quot;, \&quot;visibility\&quot;: \&quot;public\&quot;, \&quot;hardware\&quot;: \&quot;cpu\&quot;}&#39; \\   https://api.replicate.com/v1/models &#x60;&#x60;&#x60;  The response will be a model object in the following format:  &#x60;&#x60;&#x60;json {   \&quot;url\&quot;: \&quot;https://replicate.com/alice/my-model\&quot;,   \&quot;owner\&quot;: \&quot;alice\&quot;,   \&quot;name\&quot;: \&quot;my-model\&quot;,   \&quot;description\&quot;: \&quot;An example model\&quot;,   \&quot;visibility\&quot;: \&quot;public\&quot;,   \&quot;github_url\&quot;: null,   \&quot;paper_url\&quot;: null,   \&quot;license_url\&quot;: null,   \&quot;run_count\&quot;: 0,   \&quot;cover_image_url\&quot;: null,   \&quot;default_example\&quot;: null,   \&quot;latest_version\&quot;: null, } &#x60;&#x60;&#x60; 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelsCreateRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public dotnetReplicate.Client.ApiResponse<Object> ModelsCreateWithHttpInfo(ModelsCreateRequest modelsCreateRequest, int operationIndex = 0)
        {
            // verify the required parameter 'modelsCreateRequest' is set
            if (modelsCreateRequest == null)
            {
                throw new dotnetReplicate.Client.ApiException(400, "Missing required parameter 'modelsCreateRequest' when calling DefaultApi->ModelsCreate");
            }

            dotnetReplicate.Client.RequestOptions localVarRequestOptions = new dotnetReplicate.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };

            var localVarContentType = dotnetReplicate.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = dotnetReplicate.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = modelsCreateRequest;

            localVarRequestOptions.Operation = "DefaultApi.ModelsCreate";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Post<Object>("/models", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ModelsCreate", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create a model Create a model.  Example cURL request:  &#x60;&#x60;&#x60;console curl -s -X POST \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   -d &#39;{\&quot;owner\&quot;: \&quot;alice\&quot; \&quot;name\&quot;: \&quot;my-model\&quot;, \&quot;description\&quot;: \&quot;An example model\&quot;, \&quot;visibility\&quot;: \&quot;public\&quot;, \&quot;hardware\&quot;: \&quot;cpu\&quot;}&#39; \\   https://api.replicate.com/v1/models &#x60;&#x60;&#x60;  The response will be a model object in the following format:  &#x60;&#x60;&#x60;json {   \&quot;url\&quot;: \&quot;https://replicate.com/alice/my-model\&quot;,   \&quot;owner\&quot;: \&quot;alice\&quot;,   \&quot;name\&quot;: \&quot;my-model\&quot;,   \&quot;description\&quot;: \&quot;An example model\&quot;,   \&quot;visibility\&quot;: \&quot;public\&quot;,   \&quot;github_url\&quot;: null,   \&quot;paper_url\&quot;: null,   \&quot;license_url\&quot;: null,   \&quot;run_count\&quot;: 0,   \&quot;cover_image_url\&quot;: null,   \&quot;default_example\&quot;: null,   \&quot;latest_version\&quot;: null, } &#x60;&#x60;&#x60; 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelsCreateRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ModelsCreateAsync(ModelsCreateRequest modelsCreateRequest, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await ModelsCreateWithHttpInfoAsync(modelsCreateRequest, operationIndex, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Create a model Create a model.  Example cURL request:  &#x60;&#x60;&#x60;console curl -s -X POST \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   -d &#39;{\&quot;owner\&quot;: \&quot;alice\&quot; \&quot;name\&quot;: \&quot;my-model\&quot;, \&quot;description\&quot;: \&quot;An example model\&quot;, \&quot;visibility\&quot;: \&quot;public\&quot;, \&quot;hardware\&quot;: \&quot;cpu\&quot;}&#39; \\   https://api.replicate.com/v1/models &#x60;&#x60;&#x60;  The response will be a model object in the following format:  &#x60;&#x60;&#x60;json {   \&quot;url\&quot;: \&quot;https://replicate.com/alice/my-model\&quot;,   \&quot;owner\&quot;: \&quot;alice\&quot;,   \&quot;name\&quot;: \&quot;my-model\&quot;,   \&quot;description\&quot;: \&quot;An example model\&quot;,   \&quot;visibility\&quot;: \&quot;public\&quot;,   \&quot;github_url\&quot;: null,   \&quot;paper_url\&quot;: null,   \&quot;license_url\&quot;: null,   \&quot;run_count\&quot;: 0,   \&quot;cover_image_url\&quot;: null,   \&quot;default_example\&quot;: null,   \&quot;latest_version\&quot;: null, } &#x60;&#x60;&#x60; 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelsCreateRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<dotnetReplicate.Client.ApiResponse<Object>> ModelsCreateWithHttpInfoAsync(ModelsCreateRequest modelsCreateRequest, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'modelsCreateRequest' is set
            if (modelsCreateRequest == null)
            {
                throw new dotnetReplicate.Client.ApiException(400, "Missing required parameter 'modelsCreateRequest' when calling DefaultApi->ModelsCreate");
            }


            dotnetReplicate.Client.RequestOptions localVarRequestOptions = new dotnetReplicate.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };

            var localVarContentType = dotnetReplicate.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = dotnetReplicate.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = modelsCreateRequest;

            localVarRequestOptions.Operation = "DefaultApi.ModelsCreate";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<Object>("/models", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ModelsCreate", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a model Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/models/replicate/hello-world &#x60;&#x60;&#x60;  The response will be a model object in the following format:  &#x60;&#x60;&#x60;json {   \&quot;url\&quot;: \&quot;https://replicate.com/replicate/hello-world\&quot;,   \&quot;owner\&quot;: \&quot;replicate\&quot;,   \&quot;name\&quot;: \&quot;hello-world\&quot;,   \&quot;description\&quot;: \&quot;A tiny model that says hello\&quot;,   \&quot;visibility\&quot;: \&quot;public\&quot;,   \&quot;github_url\&quot;: \&quot;https://github.com/replicate/cog-examples\&quot;,   \&quot;paper_url\&quot;: null,   \&quot;license_url\&quot;: null,   \&quot;run_count\&quot;: 5681081,   \&quot;cover_image_url\&quot;: \&quot;...\&quot;,   \&quot;default_example\&quot;: {...},   \&quot;latest_version\&quot;: {...}, } &#x60;&#x60;&#x60;  The &#x60;cover_image_url&#x60; string is an HTTPS URL for an image file. This can be:  - An image uploaded by the model author. - The output file of the example prediction, if the model author has not set a cover image. - The input file of the example prediction, if the model author has not set a cover image and the example prediction has no output file. - A generic fallback image.  The &#x60;default_example&#x60; object is a [prediction](#predictions.get) created with this model.  The &#x60;latest_version&#x60; object is the model&#39;s most recently pushed [version](#models.versions.get). 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelOwner">The name of the user or organization that owns the model. </param>
        /// <param name="modelName">The name of the model. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void ModelsGet(string modelOwner, string modelName, int operationIndex = 0)
        {
            ModelsGetWithHttpInfo(modelOwner, modelName);
        }

        /// <summary>
        /// Get a model Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/models/replicate/hello-world &#x60;&#x60;&#x60;  The response will be a model object in the following format:  &#x60;&#x60;&#x60;json {   \&quot;url\&quot;: \&quot;https://replicate.com/replicate/hello-world\&quot;,   \&quot;owner\&quot;: \&quot;replicate\&quot;,   \&quot;name\&quot;: \&quot;hello-world\&quot;,   \&quot;description\&quot;: \&quot;A tiny model that says hello\&quot;,   \&quot;visibility\&quot;: \&quot;public\&quot;,   \&quot;github_url\&quot;: \&quot;https://github.com/replicate/cog-examples\&quot;,   \&quot;paper_url\&quot;: null,   \&quot;license_url\&quot;: null,   \&quot;run_count\&quot;: 5681081,   \&quot;cover_image_url\&quot;: \&quot;...\&quot;,   \&quot;default_example\&quot;: {...},   \&quot;latest_version\&quot;: {...}, } &#x60;&#x60;&#x60;  The &#x60;cover_image_url&#x60; string is an HTTPS URL for an image file. This can be:  - An image uploaded by the model author. - The output file of the example prediction, if the model author has not set a cover image. - The input file of the example prediction, if the model author has not set a cover image and the example prediction has no output file. - A generic fallback image.  The &#x60;default_example&#x60; object is a [prediction](#predictions.get) created with this model.  The &#x60;latest_version&#x60; object is the model&#39;s most recently pushed [version](#models.versions.get). 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelOwner">The name of the user or organization that owns the model. </param>
        /// <param name="modelName">The name of the model. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public dotnetReplicate.Client.ApiResponse<Object> ModelsGetWithHttpInfo(string modelOwner, string modelName, int operationIndex = 0)
        {
            // verify the required parameter 'modelOwner' is set
            if (modelOwner == null)
            {
                throw new dotnetReplicate.Client.ApiException(400, "Missing required parameter 'modelOwner' when calling DefaultApi->ModelsGet");
            }

            // verify the required parameter 'modelName' is set
            if (modelName == null)
            {
                throw new dotnetReplicate.Client.ApiException(400, "Missing required parameter 'modelName' when calling DefaultApi->ModelsGet");
            }

            dotnetReplicate.Client.RequestOptions localVarRequestOptions = new dotnetReplicate.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };

            var localVarContentType = dotnetReplicate.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = dotnetReplicate.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("model_owner", dotnetReplicate.Client.ClientUtils.ParameterToString(modelOwner)); // path parameter
            localVarRequestOptions.PathParameters.Add("model_name", dotnetReplicate.Client.ClientUtils.ParameterToString(modelName)); // path parameter

            localVarRequestOptions.Operation = "DefaultApi.ModelsGet";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Get<Object>("/models/{model_owner}/{model_name}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ModelsGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a model Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/models/replicate/hello-world &#x60;&#x60;&#x60;  The response will be a model object in the following format:  &#x60;&#x60;&#x60;json {   \&quot;url\&quot;: \&quot;https://replicate.com/replicate/hello-world\&quot;,   \&quot;owner\&quot;: \&quot;replicate\&quot;,   \&quot;name\&quot;: \&quot;hello-world\&quot;,   \&quot;description\&quot;: \&quot;A tiny model that says hello\&quot;,   \&quot;visibility\&quot;: \&quot;public\&quot;,   \&quot;github_url\&quot;: \&quot;https://github.com/replicate/cog-examples\&quot;,   \&quot;paper_url\&quot;: null,   \&quot;license_url\&quot;: null,   \&quot;run_count\&quot;: 5681081,   \&quot;cover_image_url\&quot;: \&quot;...\&quot;,   \&quot;default_example\&quot;: {...},   \&quot;latest_version\&quot;: {...}, } &#x60;&#x60;&#x60;  The &#x60;cover_image_url&#x60; string is an HTTPS URL for an image file. This can be:  - An image uploaded by the model author. - The output file of the example prediction, if the model author has not set a cover image. - The input file of the example prediction, if the model author has not set a cover image and the example prediction has no output file. - A generic fallback image.  The &#x60;default_example&#x60; object is a [prediction](#predictions.get) created with this model.  The &#x60;latest_version&#x60; object is the model&#39;s most recently pushed [version](#models.versions.get). 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelOwner">The name of the user or organization that owns the model. </param>
        /// <param name="modelName">The name of the model. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ModelsGetAsync(string modelOwner, string modelName, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await ModelsGetWithHttpInfoAsync(modelOwner, modelName, operationIndex, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a model Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/models/replicate/hello-world &#x60;&#x60;&#x60;  The response will be a model object in the following format:  &#x60;&#x60;&#x60;json {   \&quot;url\&quot;: \&quot;https://replicate.com/replicate/hello-world\&quot;,   \&quot;owner\&quot;: \&quot;replicate\&quot;,   \&quot;name\&quot;: \&quot;hello-world\&quot;,   \&quot;description\&quot;: \&quot;A tiny model that says hello\&quot;,   \&quot;visibility\&quot;: \&quot;public\&quot;,   \&quot;github_url\&quot;: \&quot;https://github.com/replicate/cog-examples\&quot;,   \&quot;paper_url\&quot;: null,   \&quot;license_url\&quot;: null,   \&quot;run_count\&quot;: 5681081,   \&quot;cover_image_url\&quot;: \&quot;...\&quot;,   \&quot;default_example\&quot;: {...},   \&quot;latest_version\&quot;: {...}, } &#x60;&#x60;&#x60;  The &#x60;cover_image_url&#x60; string is an HTTPS URL for an image file. This can be:  - An image uploaded by the model author. - The output file of the example prediction, if the model author has not set a cover image. - The input file of the example prediction, if the model author has not set a cover image and the example prediction has no output file. - A generic fallback image.  The &#x60;default_example&#x60; object is a [prediction](#predictions.get) created with this model.  The &#x60;latest_version&#x60; object is the model&#39;s most recently pushed [version](#models.versions.get). 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelOwner">The name of the user or organization that owns the model. </param>
        /// <param name="modelName">The name of the model. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<dotnetReplicate.Client.ApiResponse<Object>> ModelsGetWithHttpInfoAsync(string modelOwner, string modelName, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'modelOwner' is set
            if (modelOwner == null)
            {
                throw new dotnetReplicate.Client.ApiException(400, "Missing required parameter 'modelOwner' when calling DefaultApi->ModelsGet");
            }

            // verify the required parameter 'modelName' is set
            if (modelName == null)
            {
                throw new dotnetReplicate.Client.ApiException(400, "Missing required parameter 'modelName' when calling DefaultApi->ModelsGet");
            }


            dotnetReplicate.Client.RequestOptions localVarRequestOptions = new dotnetReplicate.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };

            var localVarContentType = dotnetReplicate.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = dotnetReplicate.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("model_owner", dotnetReplicate.Client.ClientUtils.ParameterToString(modelOwner)); // path parameter
            localVarRequestOptions.PathParameters.Add("model_name", dotnetReplicate.Client.ClientUtils.ParameterToString(modelName)); // path parameter

            localVarRequestOptions.Operation = "DefaultApi.ModelsGet";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<Object>("/models/{model_owner}/{model_name}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ModelsGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// List public models Get a paginated list of public models.  Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/models &#x60;&#x60;&#x60;  The response will be a paginated JSON array of model objects:  &#x60;&#x60;&#x60;json {   \&quot;next\&quot;: null,   \&quot;previous\&quot;: null,   \&quot;results\&quot;: [     {       \&quot;url\&quot;: \&quot;https://replicate.com/replicate/hello-world\&quot;,       \&quot;owner\&quot;: \&quot;replicate\&quot;,       \&quot;name\&quot;: \&quot;hello-world\&quot;,       \&quot;description\&quot;: \&quot;A tiny model that says hello\&quot;,       \&quot;visibility\&quot;: \&quot;public\&quot;,       \&quot;github_url\&quot;: \&quot;https://github.com/replicate/cog-examples\&quot;,       \&quot;paper_url\&quot;: null,       \&quot;license_url\&quot;: null,       \&quot;run_count\&quot;: 5681081,       \&quot;cover_image_url\&quot;: \&quot;...\&quot;,       \&quot;default_example\&quot;: {...},       \&quot;latest_version\&quot;: {...}     }   ] } &#x60;&#x60;&#x60;  The &#x60;cover_image_url&#x60; string is an HTTPS URL for an image file. This can be:  - An image uploaded by the model author. - The output file of the example prediction, if the model author has not set a cover image. - The input file of the example prediction, if the model author has not set a cover image and the example prediction has no output file. - A generic fallback image. 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void ModelsList(int operationIndex = 0)
        {
            ModelsListWithHttpInfo();
        }

        /// <summary>
        /// List public models Get a paginated list of public models.  Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/models &#x60;&#x60;&#x60;  The response will be a paginated JSON array of model objects:  &#x60;&#x60;&#x60;json {   \&quot;next\&quot;: null,   \&quot;previous\&quot;: null,   \&quot;results\&quot;: [     {       \&quot;url\&quot;: \&quot;https://replicate.com/replicate/hello-world\&quot;,       \&quot;owner\&quot;: \&quot;replicate\&quot;,       \&quot;name\&quot;: \&quot;hello-world\&quot;,       \&quot;description\&quot;: \&quot;A tiny model that says hello\&quot;,       \&quot;visibility\&quot;: \&quot;public\&quot;,       \&quot;github_url\&quot;: \&quot;https://github.com/replicate/cog-examples\&quot;,       \&quot;paper_url\&quot;: null,       \&quot;license_url\&quot;: null,       \&quot;run_count\&quot;: 5681081,       \&quot;cover_image_url\&quot;: \&quot;...\&quot;,       \&quot;default_example\&quot;: {...},       \&quot;latest_version\&quot;: {...}     }   ] } &#x60;&#x60;&#x60;  The &#x60;cover_image_url&#x60; string is an HTTPS URL for an image file. This can be:  - An image uploaded by the model author. - The output file of the example prediction, if the model author has not set a cover image. - The input file of the example prediction, if the model author has not set a cover image and the example prediction has no output file. - A generic fallback image. 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public dotnetReplicate.Client.ApiResponse<Object> ModelsListWithHttpInfo(int operationIndex = 0)
        {
            dotnetReplicate.Client.RequestOptions localVarRequestOptions = new dotnetReplicate.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };

            var localVarContentType = dotnetReplicate.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = dotnetReplicate.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }


            localVarRequestOptions.Operation = "DefaultApi.ModelsList";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Get<Object>("/models", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ModelsList", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// List public models Get a paginated list of public models.  Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/models &#x60;&#x60;&#x60;  The response will be a paginated JSON array of model objects:  &#x60;&#x60;&#x60;json {   \&quot;next\&quot;: null,   \&quot;previous\&quot;: null,   \&quot;results\&quot;: [     {       \&quot;url\&quot;: \&quot;https://replicate.com/replicate/hello-world\&quot;,       \&quot;owner\&quot;: \&quot;replicate\&quot;,       \&quot;name\&quot;: \&quot;hello-world\&quot;,       \&quot;description\&quot;: \&quot;A tiny model that says hello\&quot;,       \&quot;visibility\&quot;: \&quot;public\&quot;,       \&quot;github_url\&quot;: \&quot;https://github.com/replicate/cog-examples\&quot;,       \&quot;paper_url\&quot;: null,       \&quot;license_url\&quot;: null,       \&quot;run_count\&quot;: 5681081,       \&quot;cover_image_url\&quot;: \&quot;...\&quot;,       \&quot;default_example\&quot;: {...},       \&quot;latest_version\&quot;: {...}     }   ] } &#x60;&#x60;&#x60;  The &#x60;cover_image_url&#x60; string is an HTTPS URL for an image file. This can be:  - An image uploaded by the model author. - The output file of the example prediction, if the model author has not set a cover image. - The input file of the example prediction, if the model author has not set a cover image and the example prediction has no output file. - A generic fallback image. 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ModelsListAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await ModelsListWithHttpInfoAsync(operationIndex, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// List public models Get a paginated list of public models.  Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/models &#x60;&#x60;&#x60;  The response will be a paginated JSON array of model objects:  &#x60;&#x60;&#x60;json {   \&quot;next\&quot;: null,   \&quot;previous\&quot;: null,   \&quot;results\&quot;: [     {       \&quot;url\&quot;: \&quot;https://replicate.com/replicate/hello-world\&quot;,       \&quot;owner\&quot;: \&quot;replicate\&quot;,       \&quot;name\&quot;: \&quot;hello-world\&quot;,       \&quot;description\&quot;: \&quot;A tiny model that says hello\&quot;,       \&quot;visibility\&quot;: \&quot;public\&quot;,       \&quot;github_url\&quot;: \&quot;https://github.com/replicate/cog-examples\&quot;,       \&quot;paper_url\&quot;: null,       \&quot;license_url\&quot;: null,       \&quot;run_count\&quot;: 5681081,       \&quot;cover_image_url\&quot;: \&quot;...\&quot;,       \&quot;default_example\&quot;: {...},       \&quot;latest_version\&quot;: {...}     }   ] } &#x60;&#x60;&#x60;  The &#x60;cover_image_url&#x60; string is an HTTPS URL for an image file. This can be:  - An image uploaded by the model author. - The output file of the example prediction, if the model author has not set a cover image. - The input file of the example prediction, if the model author has not set a cover image and the example prediction has no output file. - A generic fallback image. 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<dotnetReplicate.Client.ApiResponse<Object>> ModelsListWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            dotnetReplicate.Client.RequestOptions localVarRequestOptions = new dotnetReplicate.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };

            var localVarContentType = dotnetReplicate.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = dotnetReplicate.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }


            localVarRequestOptions.Operation = "DefaultApi.ModelsList";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<Object>("/models", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ModelsList", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete a model version Delete a model version and all associated predictions, including all output files.  Model version deletion has some restrictions:  - You can only delete versions from models you own. - You can only delete versions from private models. - You cannot delete a version if someone other than you has run predictions with it.  Example cURL request:  &#x60;&#x60;&#x60;command curl -s -X DELETE \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/models/replicate/hello-world/versions/5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa &#x60;&#x60;&#x60;  The response will be an empty 202, indicating the deletion request has been accepted. It might take a few minutes to be processed. 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelOwner">The name of the user or organization that owns the model. </param>
        /// <param name="modelName">The name of the model. </param>
        /// <param name="versionId">The ID of the version. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void ModelsVersionsDelete(string modelOwner, string modelName, string versionId, int operationIndex = 0)
        {
            ModelsVersionsDeleteWithHttpInfo(modelOwner, modelName, versionId);
        }

        /// <summary>
        /// Delete a model version Delete a model version and all associated predictions, including all output files.  Model version deletion has some restrictions:  - You can only delete versions from models you own. - You can only delete versions from private models. - You cannot delete a version if someone other than you has run predictions with it.  Example cURL request:  &#x60;&#x60;&#x60;command curl -s -X DELETE \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/models/replicate/hello-world/versions/5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa &#x60;&#x60;&#x60;  The response will be an empty 202, indicating the deletion request has been accepted. It might take a few minutes to be processed. 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelOwner">The name of the user or organization that owns the model. </param>
        /// <param name="modelName">The name of the model. </param>
        /// <param name="versionId">The ID of the version. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public dotnetReplicate.Client.ApiResponse<Object> ModelsVersionsDeleteWithHttpInfo(string modelOwner, string modelName, string versionId, int operationIndex = 0)
        {
            // verify the required parameter 'modelOwner' is set
            if (modelOwner == null)
            {
                throw new dotnetReplicate.Client.ApiException(400, "Missing required parameter 'modelOwner' when calling DefaultApi->ModelsVersionsDelete");
            }

            // verify the required parameter 'modelName' is set
            if (modelName == null)
            {
                throw new dotnetReplicate.Client.ApiException(400, "Missing required parameter 'modelName' when calling DefaultApi->ModelsVersionsDelete");
            }

            // verify the required parameter 'versionId' is set
            if (versionId == null)
            {
                throw new dotnetReplicate.Client.ApiException(400, "Missing required parameter 'versionId' when calling DefaultApi->ModelsVersionsDelete");
            }

            dotnetReplicate.Client.RequestOptions localVarRequestOptions = new dotnetReplicate.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };

            var localVarContentType = dotnetReplicate.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = dotnetReplicate.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("model_owner", dotnetReplicate.Client.ClientUtils.ParameterToString(modelOwner)); // path parameter
            localVarRequestOptions.PathParameters.Add("model_name", dotnetReplicate.Client.ClientUtils.ParameterToString(modelName)); // path parameter
            localVarRequestOptions.PathParameters.Add("version_id", dotnetReplicate.Client.ClientUtils.ParameterToString(versionId)); // path parameter

            localVarRequestOptions.Operation = "DefaultApi.ModelsVersionsDelete";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Delete<Object>("/models/{model_owner}/{model_name}/versions/{version_id}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ModelsVersionsDelete", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete a model version Delete a model version and all associated predictions, including all output files.  Model version deletion has some restrictions:  - You can only delete versions from models you own. - You can only delete versions from private models. - You cannot delete a version if someone other than you has run predictions with it.  Example cURL request:  &#x60;&#x60;&#x60;command curl -s -X DELETE \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/models/replicate/hello-world/versions/5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa &#x60;&#x60;&#x60;  The response will be an empty 202, indicating the deletion request has been accepted. It might take a few minutes to be processed. 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelOwner">The name of the user or organization that owns the model. </param>
        /// <param name="modelName">The name of the model. </param>
        /// <param name="versionId">The ID of the version. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ModelsVersionsDeleteAsync(string modelOwner, string modelName, string versionId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await ModelsVersionsDeleteWithHttpInfoAsync(modelOwner, modelName, versionId, operationIndex, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Delete a model version Delete a model version and all associated predictions, including all output files.  Model version deletion has some restrictions:  - You can only delete versions from models you own. - You can only delete versions from private models. - You cannot delete a version if someone other than you has run predictions with it.  Example cURL request:  &#x60;&#x60;&#x60;command curl -s -X DELETE \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/models/replicate/hello-world/versions/5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa &#x60;&#x60;&#x60;  The response will be an empty 202, indicating the deletion request has been accepted. It might take a few minutes to be processed. 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelOwner">The name of the user or organization that owns the model. </param>
        /// <param name="modelName">The name of the model. </param>
        /// <param name="versionId">The ID of the version. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<dotnetReplicate.Client.ApiResponse<Object>> ModelsVersionsDeleteWithHttpInfoAsync(string modelOwner, string modelName, string versionId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'modelOwner' is set
            if (modelOwner == null)
            {
                throw new dotnetReplicate.Client.ApiException(400, "Missing required parameter 'modelOwner' when calling DefaultApi->ModelsVersionsDelete");
            }

            // verify the required parameter 'modelName' is set
            if (modelName == null)
            {
                throw new dotnetReplicate.Client.ApiException(400, "Missing required parameter 'modelName' when calling DefaultApi->ModelsVersionsDelete");
            }

            // verify the required parameter 'versionId' is set
            if (versionId == null)
            {
                throw new dotnetReplicate.Client.ApiException(400, "Missing required parameter 'versionId' when calling DefaultApi->ModelsVersionsDelete");
            }


            dotnetReplicate.Client.RequestOptions localVarRequestOptions = new dotnetReplicate.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };

            var localVarContentType = dotnetReplicate.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = dotnetReplicate.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("model_owner", dotnetReplicate.Client.ClientUtils.ParameterToString(modelOwner)); // path parameter
            localVarRequestOptions.PathParameters.Add("model_name", dotnetReplicate.Client.ClientUtils.ParameterToString(modelName)); // path parameter
            localVarRequestOptions.PathParameters.Add("version_id", dotnetReplicate.Client.ClientUtils.ParameterToString(versionId)); // path parameter

            localVarRequestOptions.Operation = "DefaultApi.ModelsVersionsDelete";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.DeleteAsync<Object>("/models/{model_owner}/{model_name}/versions/{version_id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ModelsVersionsDelete", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a model version Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/models/replicate/hello-world/versions/5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa &#x60;&#x60;&#x60;  The response will be the version object:  &#x60;&#x60;&#x60;json {   \&quot;id\&quot;: \&quot;5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa\&quot;,   \&quot;created_at\&quot;: \&quot;2022-04-26T19:29:04.418669Z\&quot;,   \&quot;cog_version\&quot;: \&quot;0.3.0\&quot;,   \&quot;openapi_schema\&quot;: {...} } &#x60;&#x60;&#x60;  Every model describes its inputs and outputs with [OpenAPI Schema Objects](https://spec.openapis.org/oas/latest.html#schemaObject) in the &#x60;openapi_schema&#x60; property.  The &#x60;openapi_schema.components.schemas.Input&#x60; property for the [replicate/hello-world](https://replicate.com/replicate/hello-world) model looks like this:  &#x60;&#x60;&#x60;json {   \&quot;type\&quot;: \&quot;object\&quot;,   \&quot;title\&quot;: \&quot;Input\&quot;,   \&quot;required\&quot;: [     \&quot;text\&quot;   ],   \&quot;properties\&quot;: {     \&quot;text\&quot;: {       \&quot;x-order\&quot;: 0,       \&quot;type\&quot;: \&quot;string\&quot;,       \&quot;title\&quot;: \&quot;Text\&quot;,       \&quot;description\&quot;: \&quot;Text to prefix with &#39;hello &#39;\&quot;     }   } } &#x60;&#x60;&#x60;  The &#x60;openapi_schema.components.schemas.Output&#x60; property for the [replicate/hello-world](https://replicate.com/replicate/hello-world) model looks like this:  &#x60;&#x60;&#x60;json {   \&quot;type\&quot;: \&quot;string\&quot;,   \&quot;title\&quot;: \&quot;Output\&quot; } &#x60;&#x60;&#x60;  For more details, see the docs on [Cog&#39;s supported input and output types](https://github.com/replicate/cog/blob/75b7802219e7cd4cee845e34c4c22139558615d4/docs/python.md#input-and-output-types) 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelOwner">The name of the user or organization that owns the model. </param>
        /// <param name="modelName">The name of the model. </param>
        /// <param name="versionId">The ID of the version. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void ModelsVersionsGet(string modelOwner, string modelName, string versionId, int operationIndex = 0)
        {
            ModelsVersionsGetWithHttpInfo(modelOwner, modelName, versionId);
        }

        /// <summary>
        /// Get a model version Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/models/replicate/hello-world/versions/5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa &#x60;&#x60;&#x60;  The response will be the version object:  &#x60;&#x60;&#x60;json {   \&quot;id\&quot;: \&quot;5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa\&quot;,   \&quot;created_at\&quot;: \&quot;2022-04-26T19:29:04.418669Z\&quot;,   \&quot;cog_version\&quot;: \&quot;0.3.0\&quot;,   \&quot;openapi_schema\&quot;: {...} } &#x60;&#x60;&#x60;  Every model describes its inputs and outputs with [OpenAPI Schema Objects](https://spec.openapis.org/oas/latest.html#schemaObject) in the &#x60;openapi_schema&#x60; property.  The &#x60;openapi_schema.components.schemas.Input&#x60; property for the [replicate/hello-world](https://replicate.com/replicate/hello-world) model looks like this:  &#x60;&#x60;&#x60;json {   \&quot;type\&quot;: \&quot;object\&quot;,   \&quot;title\&quot;: \&quot;Input\&quot;,   \&quot;required\&quot;: [     \&quot;text\&quot;   ],   \&quot;properties\&quot;: {     \&quot;text\&quot;: {       \&quot;x-order\&quot;: 0,       \&quot;type\&quot;: \&quot;string\&quot;,       \&quot;title\&quot;: \&quot;Text\&quot;,       \&quot;description\&quot;: \&quot;Text to prefix with &#39;hello &#39;\&quot;     }   } } &#x60;&#x60;&#x60;  The &#x60;openapi_schema.components.schemas.Output&#x60; property for the [replicate/hello-world](https://replicate.com/replicate/hello-world) model looks like this:  &#x60;&#x60;&#x60;json {   \&quot;type\&quot;: \&quot;string\&quot;,   \&quot;title\&quot;: \&quot;Output\&quot; } &#x60;&#x60;&#x60;  For more details, see the docs on [Cog&#39;s supported input and output types](https://github.com/replicate/cog/blob/75b7802219e7cd4cee845e34c4c22139558615d4/docs/python.md#input-and-output-types) 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelOwner">The name of the user or organization that owns the model. </param>
        /// <param name="modelName">The name of the model. </param>
        /// <param name="versionId">The ID of the version. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public dotnetReplicate.Client.ApiResponse<Object> ModelsVersionsGetWithHttpInfo(string modelOwner, string modelName, string versionId, int operationIndex = 0)
        {
            // verify the required parameter 'modelOwner' is set
            if (modelOwner == null)
            {
                throw new dotnetReplicate.Client.ApiException(400, "Missing required parameter 'modelOwner' when calling DefaultApi->ModelsVersionsGet");
            }

            // verify the required parameter 'modelName' is set
            if (modelName == null)
            {
                throw new dotnetReplicate.Client.ApiException(400, "Missing required parameter 'modelName' when calling DefaultApi->ModelsVersionsGet");
            }

            // verify the required parameter 'versionId' is set
            if (versionId == null)
            {
                throw new dotnetReplicate.Client.ApiException(400, "Missing required parameter 'versionId' when calling DefaultApi->ModelsVersionsGet");
            }

            dotnetReplicate.Client.RequestOptions localVarRequestOptions = new dotnetReplicate.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };

            var localVarContentType = dotnetReplicate.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = dotnetReplicate.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("model_owner", dotnetReplicate.Client.ClientUtils.ParameterToString(modelOwner)); // path parameter
            localVarRequestOptions.PathParameters.Add("model_name", dotnetReplicate.Client.ClientUtils.ParameterToString(modelName)); // path parameter
            localVarRequestOptions.PathParameters.Add("version_id", dotnetReplicate.Client.ClientUtils.ParameterToString(versionId)); // path parameter

            localVarRequestOptions.Operation = "DefaultApi.ModelsVersionsGet";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Get<Object>("/models/{model_owner}/{model_name}/versions/{version_id}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ModelsVersionsGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a model version Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/models/replicate/hello-world/versions/5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa &#x60;&#x60;&#x60;  The response will be the version object:  &#x60;&#x60;&#x60;json {   \&quot;id\&quot;: \&quot;5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa\&quot;,   \&quot;created_at\&quot;: \&quot;2022-04-26T19:29:04.418669Z\&quot;,   \&quot;cog_version\&quot;: \&quot;0.3.0\&quot;,   \&quot;openapi_schema\&quot;: {...} } &#x60;&#x60;&#x60;  Every model describes its inputs and outputs with [OpenAPI Schema Objects](https://spec.openapis.org/oas/latest.html#schemaObject) in the &#x60;openapi_schema&#x60; property.  The &#x60;openapi_schema.components.schemas.Input&#x60; property for the [replicate/hello-world](https://replicate.com/replicate/hello-world) model looks like this:  &#x60;&#x60;&#x60;json {   \&quot;type\&quot;: \&quot;object\&quot;,   \&quot;title\&quot;: \&quot;Input\&quot;,   \&quot;required\&quot;: [     \&quot;text\&quot;   ],   \&quot;properties\&quot;: {     \&quot;text\&quot;: {       \&quot;x-order\&quot;: 0,       \&quot;type\&quot;: \&quot;string\&quot;,       \&quot;title\&quot;: \&quot;Text\&quot;,       \&quot;description\&quot;: \&quot;Text to prefix with &#39;hello &#39;\&quot;     }   } } &#x60;&#x60;&#x60;  The &#x60;openapi_schema.components.schemas.Output&#x60; property for the [replicate/hello-world](https://replicate.com/replicate/hello-world) model looks like this:  &#x60;&#x60;&#x60;json {   \&quot;type\&quot;: \&quot;string\&quot;,   \&quot;title\&quot;: \&quot;Output\&quot; } &#x60;&#x60;&#x60;  For more details, see the docs on [Cog&#39;s supported input and output types](https://github.com/replicate/cog/blob/75b7802219e7cd4cee845e34c4c22139558615d4/docs/python.md#input-and-output-types) 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelOwner">The name of the user or organization that owns the model. </param>
        /// <param name="modelName">The name of the model. </param>
        /// <param name="versionId">The ID of the version. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ModelsVersionsGetAsync(string modelOwner, string modelName, string versionId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await ModelsVersionsGetWithHttpInfoAsync(modelOwner, modelName, versionId, operationIndex, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a model version Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/models/replicate/hello-world/versions/5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa &#x60;&#x60;&#x60;  The response will be the version object:  &#x60;&#x60;&#x60;json {   \&quot;id\&quot;: \&quot;5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa\&quot;,   \&quot;created_at\&quot;: \&quot;2022-04-26T19:29:04.418669Z\&quot;,   \&quot;cog_version\&quot;: \&quot;0.3.0\&quot;,   \&quot;openapi_schema\&quot;: {...} } &#x60;&#x60;&#x60;  Every model describes its inputs and outputs with [OpenAPI Schema Objects](https://spec.openapis.org/oas/latest.html#schemaObject) in the &#x60;openapi_schema&#x60; property.  The &#x60;openapi_schema.components.schemas.Input&#x60; property for the [replicate/hello-world](https://replicate.com/replicate/hello-world) model looks like this:  &#x60;&#x60;&#x60;json {   \&quot;type\&quot;: \&quot;object\&quot;,   \&quot;title\&quot;: \&quot;Input\&quot;,   \&quot;required\&quot;: [     \&quot;text\&quot;   ],   \&quot;properties\&quot;: {     \&quot;text\&quot;: {       \&quot;x-order\&quot;: 0,       \&quot;type\&quot;: \&quot;string\&quot;,       \&quot;title\&quot;: \&quot;Text\&quot;,       \&quot;description\&quot;: \&quot;Text to prefix with &#39;hello &#39;\&quot;     }   } } &#x60;&#x60;&#x60;  The &#x60;openapi_schema.components.schemas.Output&#x60; property for the [replicate/hello-world](https://replicate.com/replicate/hello-world) model looks like this:  &#x60;&#x60;&#x60;json {   \&quot;type\&quot;: \&quot;string\&quot;,   \&quot;title\&quot;: \&quot;Output\&quot; } &#x60;&#x60;&#x60;  For more details, see the docs on [Cog&#39;s supported input and output types](https://github.com/replicate/cog/blob/75b7802219e7cd4cee845e34c4c22139558615d4/docs/python.md#input-and-output-types) 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelOwner">The name of the user or organization that owns the model. </param>
        /// <param name="modelName">The name of the model. </param>
        /// <param name="versionId">The ID of the version. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<dotnetReplicate.Client.ApiResponse<Object>> ModelsVersionsGetWithHttpInfoAsync(string modelOwner, string modelName, string versionId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'modelOwner' is set
            if (modelOwner == null)
            {
                throw new dotnetReplicate.Client.ApiException(400, "Missing required parameter 'modelOwner' when calling DefaultApi->ModelsVersionsGet");
            }

            // verify the required parameter 'modelName' is set
            if (modelName == null)
            {
                throw new dotnetReplicate.Client.ApiException(400, "Missing required parameter 'modelName' when calling DefaultApi->ModelsVersionsGet");
            }

            // verify the required parameter 'versionId' is set
            if (versionId == null)
            {
                throw new dotnetReplicate.Client.ApiException(400, "Missing required parameter 'versionId' when calling DefaultApi->ModelsVersionsGet");
            }


            dotnetReplicate.Client.RequestOptions localVarRequestOptions = new dotnetReplicate.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };

            var localVarContentType = dotnetReplicate.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = dotnetReplicate.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("model_owner", dotnetReplicate.Client.ClientUtils.ParameterToString(modelOwner)); // path parameter
            localVarRequestOptions.PathParameters.Add("model_name", dotnetReplicate.Client.ClientUtils.ParameterToString(modelName)); // path parameter
            localVarRequestOptions.PathParameters.Add("version_id", dotnetReplicate.Client.ClientUtils.ParameterToString(versionId)); // path parameter

            localVarRequestOptions.Operation = "DefaultApi.ModelsVersionsGet";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<Object>("/models/{model_owner}/{model_name}/versions/{version_id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ModelsVersionsGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// List model versions Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/models/replicate/hello-world/versions &#x60;&#x60;&#x60;  The response will be a JSON array of model version objects, sorted with the most recent version first:  &#x60;&#x60;&#x60;json {   \&quot;next\&quot;: null,   \&quot;previous\&quot;: null,   \&quot;results\&quot;: [     {       \&quot;id\&quot;: \&quot;5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa\&quot;,       \&quot;created_at\&quot;: \&quot;2022-04-26T19:29:04.418669Z\&quot;,       \&quot;cog_version\&quot;: \&quot;0.3.0\&quot;,       \&quot;openapi_schema\&quot;: {...}     }   ] } &#x60;&#x60;&#x60; 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelOwner">The name of the user or organization that owns the model. </param>
        /// <param name="modelName">The name of the model. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void ModelsVersionsList(string modelOwner, string modelName, int operationIndex = 0)
        {
            ModelsVersionsListWithHttpInfo(modelOwner, modelName);
        }

        /// <summary>
        /// List model versions Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/models/replicate/hello-world/versions &#x60;&#x60;&#x60;  The response will be a JSON array of model version objects, sorted with the most recent version first:  &#x60;&#x60;&#x60;json {   \&quot;next\&quot;: null,   \&quot;previous\&quot;: null,   \&quot;results\&quot;: [     {       \&quot;id\&quot;: \&quot;5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa\&quot;,       \&quot;created_at\&quot;: \&quot;2022-04-26T19:29:04.418669Z\&quot;,       \&quot;cog_version\&quot;: \&quot;0.3.0\&quot;,       \&quot;openapi_schema\&quot;: {...}     }   ] } &#x60;&#x60;&#x60; 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelOwner">The name of the user or organization that owns the model. </param>
        /// <param name="modelName">The name of the model. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public dotnetReplicate.Client.ApiResponse<Object> ModelsVersionsListWithHttpInfo(string modelOwner, string modelName, int operationIndex = 0)
        {
            // verify the required parameter 'modelOwner' is set
            if (modelOwner == null)
            {
                throw new dotnetReplicate.Client.ApiException(400, "Missing required parameter 'modelOwner' when calling DefaultApi->ModelsVersionsList");
            }

            // verify the required parameter 'modelName' is set
            if (modelName == null)
            {
                throw new dotnetReplicate.Client.ApiException(400, "Missing required parameter 'modelName' when calling DefaultApi->ModelsVersionsList");
            }

            dotnetReplicate.Client.RequestOptions localVarRequestOptions = new dotnetReplicate.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };

            var localVarContentType = dotnetReplicate.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = dotnetReplicate.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("model_owner", dotnetReplicate.Client.ClientUtils.ParameterToString(modelOwner)); // path parameter
            localVarRequestOptions.PathParameters.Add("model_name", dotnetReplicate.Client.ClientUtils.ParameterToString(modelName)); // path parameter

            localVarRequestOptions.Operation = "DefaultApi.ModelsVersionsList";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Get<Object>("/models/{model_owner}/{model_name}/versions", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ModelsVersionsList", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// List model versions Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/models/replicate/hello-world/versions &#x60;&#x60;&#x60;  The response will be a JSON array of model version objects, sorted with the most recent version first:  &#x60;&#x60;&#x60;json {   \&quot;next\&quot;: null,   \&quot;previous\&quot;: null,   \&quot;results\&quot;: [     {       \&quot;id\&quot;: \&quot;5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa\&quot;,       \&quot;created_at\&quot;: \&quot;2022-04-26T19:29:04.418669Z\&quot;,       \&quot;cog_version\&quot;: \&quot;0.3.0\&quot;,       \&quot;openapi_schema\&quot;: {...}     }   ] } &#x60;&#x60;&#x60; 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelOwner">The name of the user or organization that owns the model. </param>
        /// <param name="modelName">The name of the model. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ModelsVersionsListAsync(string modelOwner, string modelName, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await ModelsVersionsListWithHttpInfoAsync(modelOwner, modelName, operationIndex, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// List model versions Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/models/replicate/hello-world/versions &#x60;&#x60;&#x60;  The response will be a JSON array of model version objects, sorted with the most recent version first:  &#x60;&#x60;&#x60;json {   \&quot;next\&quot;: null,   \&quot;previous\&quot;: null,   \&quot;results\&quot;: [     {       \&quot;id\&quot;: \&quot;5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa\&quot;,       \&quot;created_at\&quot;: \&quot;2022-04-26T19:29:04.418669Z\&quot;,       \&quot;cog_version\&quot;: \&quot;0.3.0\&quot;,       \&quot;openapi_schema\&quot;: {...}     }   ] } &#x60;&#x60;&#x60; 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelOwner">The name of the user or organization that owns the model. </param>
        /// <param name="modelName">The name of the model. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<dotnetReplicate.Client.ApiResponse<Object>> ModelsVersionsListWithHttpInfoAsync(string modelOwner, string modelName, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'modelOwner' is set
            if (modelOwner == null)
            {
                throw new dotnetReplicate.Client.ApiException(400, "Missing required parameter 'modelOwner' when calling DefaultApi->ModelsVersionsList");
            }

            // verify the required parameter 'modelName' is set
            if (modelName == null)
            {
                throw new dotnetReplicate.Client.ApiException(400, "Missing required parameter 'modelName' when calling DefaultApi->ModelsVersionsList");
            }


            dotnetReplicate.Client.RequestOptions localVarRequestOptions = new dotnetReplicate.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };

            var localVarContentType = dotnetReplicate.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = dotnetReplicate.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("model_owner", dotnetReplicate.Client.ClientUtils.ParameterToString(modelOwner)); // path parameter
            localVarRequestOptions.PathParameters.Add("model_name", dotnetReplicate.Client.ClientUtils.ParameterToString(modelName)); // path parameter

            localVarRequestOptions.Operation = "DefaultApi.ModelsVersionsList";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<Object>("/models/{model_owner}/{model_name}/versions", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ModelsVersionsList", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Cancel a prediction 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="predictionId">The ID of the prediction to cancel. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void PredictionsCancel(string predictionId, int operationIndex = 0)
        {
            PredictionsCancelWithHttpInfo(predictionId);
        }

        /// <summary>
        /// Cancel a prediction 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="predictionId">The ID of the prediction to cancel. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public dotnetReplicate.Client.ApiResponse<Object> PredictionsCancelWithHttpInfo(string predictionId, int operationIndex = 0)
        {
            // verify the required parameter 'predictionId' is set
            if (predictionId == null)
            {
                throw new dotnetReplicate.Client.ApiException(400, "Missing required parameter 'predictionId' when calling DefaultApi->PredictionsCancel");
            }

            dotnetReplicate.Client.RequestOptions localVarRequestOptions = new dotnetReplicate.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };

            var localVarContentType = dotnetReplicate.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = dotnetReplicate.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("prediction_id", dotnetReplicate.Client.ClientUtils.ParameterToString(predictionId)); // path parameter

            localVarRequestOptions.Operation = "DefaultApi.PredictionsCancel";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Post<Object>("/predictions/{prediction_id}/cancel", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PredictionsCancel", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Cancel a prediction 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="predictionId">The ID of the prediction to cancel. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PredictionsCancelAsync(string predictionId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await PredictionsCancelWithHttpInfoAsync(predictionId, operationIndex, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Cancel a prediction 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="predictionId">The ID of the prediction to cancel. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<dotnetReplicate.Client.ApiResponse<Object>> PredictionsCancelWithHttpInfoAsync(string predictionId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'predictionId' is set
            if (predictionId == null)
            {
                throw new dotnetReplicate.Client.ApiException(400, "Missing required parameter 'predictionId' when calling DefaultApi->PredictionsCancel");
            }


            dotnetReplicate.Client.RequestOptions localVarRequestOptions = new dotnetReplicate.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };

            var localVarContentType = dotnetReplicate.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = dotnetReplicate.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("prediction_id", dotnetReplicate.Client.ClientUtils.ParameterToString(predictionId)); // path parameter

            localVarRequestOptions.Operation = "DefaultApi.PredictionsCancel";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<Object>("/predictions/{prediction_id}/cancel", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PredictionsCancel", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create a prediction Start a new prediction for the model version and inputs you provide.  Example request body:  &#x60;&#x60;&#x60;json {   \&quot;version\&quot;: \&quot;5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa\&quot;,   \&quot;input\&quot;: {     \&quot;text\&quot;: \&quot;Alice\&quot;   } } &#x60;&#x60;&#x60;  Example cURL request:  &#x60;&#x60;&#x60;console curl -s -X POST \\   -d &#39;{\&quot;version\&quot;: \&quot;5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa\&quot;, \&quot;input\&quot;: {\&quot;text\&quot;: \&quot;Alice\&quot;}}&#39; \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   -H &#39;Content-Type: application/json&#39; \\   https://api.replicate.com/v1/predictions &#x60;&#x60;&#x60;  The response will be the prediction object:  &#x60;&#x60;&#x60;json {   \&quot;id\&quot;: \&quot;gm3qorzdhgbfurvjtvhg6dckhu\&quot;,   \&quot;model\&quot;: \&quot;replicate/hello-world\&quot;,   \&quot;version\&quot;: \&quot;5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa\&quot;,   \&quot;input\&quot;: {     \&quot;text\&quot;: \&quot;Alice\&quot;   },   \&quot;logs\&quot;: \&quot;\&quot;,   \&quot;error\&quot;: null,   \&quot;status\&quot;: \&quot;starting\&quot;,   \&quot;created_at\&quot;: \&quot;2023-09-08T16:19:34.765994657Z\&quot;,   \&quot;urls\&quot;: {     \&quot;cancel\&quot;: \&quot;https://api.replicate.com/v1/predictions/gm3qorzdhgbfurvjtvhg6dckhu/cancel\&quot;,     \&quot;get\&quot;: \&quot;https://api.replicate.com/v1/predictions/gm3qorzdhgbfurvjtvhg6dckhu\&quot;   } } &#x60;&#x60;&#x60;  As models can take several seconds or more to run, the output will not be available immediately. To get the final result of the prediction you should either provide a &#x60;webhook&#x60; HTTPS URL for us to call when the results are ready, or poll the [get a prediction](#predictions.get) endpoint until it has finished.  Input and output (including any files) will be automatically deleted after an hour, so you must save a copy of any files in the output if you&#39;d like to continue using them.  Output files are served by &#x60;replicate.delivery&#x60; and its subdomains. If you use an allow list of external domains for your assets, add &#x60;replicate.delivery&#x60; and &#x60;*.replicate.delivery&#x60; to it. 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="predictionsCreateRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void PredictionsCreate(PredictionsCreateRequest? predictionsCreateRequest = default(PredictionsCreateRequest?), int operationIndex = 0)
        {
            PredictionsCreateWithHttpInfo(predictionsCreateRequest);
        }

        /// <summary>
        /// Create a prediction Start a new prediction for the model version and inputs you provide.  Example request body:  &#x60;&#x60;&#x60;json {   \&quot;version\&quot;: \&quot;5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa\&quot;,   \&quot;input\&quot;: {     \&quot;text\&quot;: \&quot;Alice\&quot;   } } &#x60;&#x60;&#x60;  Example cURL request:  &#x60;&#x60;&#x60;console curl -s -X POST \\   -d &#39;{\&quot;version\&quot;: \&quot;5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa\&quot;, \&quot;input\&quot;: {\&quot;text\&quot;: \&quot;Alice\&quot;}}&#39; \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   -H &#39;Content-Type: application/json&#39; \\   https://api.replicate.com/v1/predictions &#x60;&#x60;&#x60;  The response will be the prediction object:  &#x60;&#x60;&#x60;json {   \&quot;id\&quot;: \&quot;gm3qorzdhgbfurvjtvhg6dckhu\&quot;,   \&quot;model\&quot;: \&quot;replicate/hello-world\&quot;,   \&quot;version\&quot;: \&quot;5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa\&quot;,   \&quot;input\&quot;: {     \&quot;text\&quot;: \&quot;Alice\&quot;   },   \&quot;logs\&quot;: \&quot;\&quot;,   \&quot;error\&quot;: null,   \&quot;status\&quot;: \&quot;starting\&quot;,   \&quot;created_at\&quot;: \&quot;2023-09-08T16:19:34.765994657Z\&quot;,   \&quot;urls\&quot;: {     \&quot;cancel\&quot;: \&quot;https://api.replicate.com/v1/predictions/gm3qorzdhgbfurvjtvhg6dckhu/cancel\&quot;,     \&quot;get\&quot;: \&quot;https://api.replicate.com/v1/predictions/gm3qorzdhgbfurvjtvhg6dckhu\&quot;   } } &#x60;&#x60;&#x60;  As models can take several seconds or more to run, the output will not be available immediately. To get the final result of the prediction you should either provide a &#x60;webhook&#x60; HTTPS URL for us to call when the results are ready, or poll the [get a prediction](#predictions.get) endpoint until it has finished.  Input and output (including any files) will be automatically deleted after an hour, so you must save a copy of any files in the output if you&#39;d like to continue using them.  Output files are served by &#x60;replicate.delivery&#x60; and its subdomains. If you use an allow list of external domains for your assets, add &#x60;replicate.delivery&#x60; and &#x60;*.replicate.delivery&#x60; to it. 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="predictionsCreateRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public dotnetReplicate.Client.ApiResponse<Object> PredictionsCreateWithHttpInfo(PredictionsCreateRequest? predictionsCreateRequest = default(PredictionsCreateRequest?), int operationIndex = 0)
        {
            dotnetReplicate.Client.RequestOptions localVarRequestOptions = new dotnetReplicate.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };

            var localVarContentType = dotnetReplicate.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = dotnetReplicate.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = predictionsCreateRequest;

            localVarRequestOptions.Operation = "DefaultApi.PredictionsCreate";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Post<Object>("/predictions", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PredictionsCreate", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create a prediction Start a new prediction for the model version and inputs you provide.  Example request body:  &#x60;&#x60;&#x60;json {   \&quot;version\&quot;: \&quot;5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa\&quot;,   \&quot;input\&quot;: {     \&quot;text\&quot;: \&quot;Alice\&quot;   } } &#x60;&#x60;&#x60;  Example cURL request:  &#x60;&#x60;&#x60;console curl -s -X POST \\   -d &#39;{\&quot;version\&quot;: \&quot;5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa\&quot;, \&quot;input\&quot;: {\&quot;text\&quot;: \&quot;Alice\&quot;}}&#39; \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   -H &#39;Content-Type: application/json&#39; \\   https://api.replicate.com/v1/predictions &#x60;&#x60;&#x60;  The response will be the prediction object:  &#x60;&#x60;&#x60;json {   \&quot;id\&quot;: \&quot;gm3qorzdhgbfurvjtvhg6dckhu\&quot;,   \&quot;model\&quot;: \&quot;replicate/hello-world\&quot;,   \&quot;version\&quot;: \&quot;5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa\&quot;,   \&quot;input\&quot;: {     \&quot;text\&quot;: \&quot;Alice\&quot;   },   \&quot;logs\&quot;: \&quot;\&quot;,   \&quot;error\&quot;: null,   \&quot;status\&quot;: \&quot;starting\&quot;,   \&quot;created_at\&quot;: \&quot;2023-09-08T16:19:34.765994657Z\&quot;,   \&quot;urls\&quot;: {     \&quot;cancel\&quot;: \&quot;https://api.replicate.com/v1/predictions/gm3qorzdhgbfurvjtvhg6dckhu/cancel\&quot;,     \&quot;get\&quot;: \&quot;https://api.replicate.com/v1/predictions/gm3qorzdhgbfurvjtvhg6dckhu\&quot;   } } &#x60;&#x60;&#x60;  As models can take several seconds or more to run, the output will not be available immediately. To get the final result of the prediction you should either provide a &#x60;webhook&#x60; HTTPS URL for us to call when the results are ready, or poll the [get a prediction](#predictions.get) endpoint until it has finished.  Input and output (including any files) will be automatically deleted after an hour, so you must save a copy of any files in the output if you&#39;d like to continue using them.  Output files are served by &#x60;replicate.delivery&#x60; and its subdomains. If you use an allow list of external domains for your assets, add &#x60;replicate.delivery&#x60; and &#x60;*.replicate.delivery&#x60; to it. 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="predictionsCreateRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PredictionsCreateAsync(PredictionsCreateRequest? predictionsCreateRequest = default(PredictionsCreateRequest?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await PredictionsCreateWithHttpInfoAsync(predictionsCreateRequest, operationIndex, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Create a prediction Start a new prediction for the model version and inputs you provide.  Example request body:  &#x60;&#x60;&#x60;json {   \&quot;version\&quot;: \&quot;5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa\&quot;,   \&quot;input\&quot;: {     \&quot;text\&quot;: \&quot;Alice\&quot;   } } &#x60;&#x60;&#x60;  Example cURL request:  &#x60;&#x60;&#x60;console curl -s -X POST \\   -d &#39;{\&quot;version\&quot;: \&quot;5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa\&quot;, \&quot;input\&quot;: {\&quot;text\&quot;: \&quot;Alice\&quot;}}&#39; \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   -H &#39;Content-Type: application/json&#39; \\   https://api.replicate.com/v1/predictions &#x60;&#x60;&#x60;  The response will be the prediction object:  &#x60;&#x60;&#x60;json {   \&quot;id\&quot;: \&quot;gm3qorzdhgbfurvjtvhg6dckhu\&quot;,   \&quot;model\&quot;: \&quot;replicate/hello-world\&quot;,   \&quot;version\&quot;: \&quot;5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa\&quot;,   \&quot;input\&quot;: {     \&quot;text\&quot;: \&quot;Alice\&quot;   },   \&quot;logs\&quot;: \&quot;\&quot;,   \&quot;error\&quot;: null,   \&quot;status\&quot;: \&quot;starting\&quot;,   \&quot;created_at\&quot;: \&quot;2023-09-08T16:19:34.765994657Z\&quot;,   \&quot;urls\&quot;: {     \&quot;cancel\&quot;: \&quot;https://api.replicate.com/v1/predictions/gm3qorzdhgbfurvjtvhg6dckhu/cancel\&quot;,     \&quot;get\&quot;: \&quot;https://api.replicate.com/v1/predictions/gm3qorzdhgbfurvjtvhg6dckhu\&quot;   } } &#x60;&#x60;&#x60;  As models can take several seconds or more to run, the output will not be available immediately. To get the final result of the prediction you should either provide a &#x60;webhook&#x60; HTTPS URL for us to call when the results are ready, or poll the [get a prediction](#predictions.get) endpoint until it has finished.  Input and output (including any files) will be automatically deleted after an hour, so you must save a copy of any files in the output if you&#39;d like to continue using them.  Output files are served by &#x60;replicate.delivery&#x60; and its subdomains. If you use an allow list of external domains for your assets, add &#x60;replicate.delivery&#x60; and &#x60;*.replicate.delivery&#x60; to it. 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="predictionsCreateRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<dotnetReplicate.Client.ApiResponse<Object>> PredictionsCreateWithHttpInfoAsync(PredictionsCreateRequest? predictionsCreateRequest = default(PredictionsCreateRequest?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            dotnetReplicate.Client.RequestOptions localVarRequestOptions = new dotnetReplicate.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };

            var localVarContentType = dotnetReplicate.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = dotnetReplicate.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = predictionsCreateRequest;

            localVarRequestOptions.Operation = "DefaultApi.PredictionsCreate";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<Object>("/predictions", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PredictionsCreate", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a prediction Get the current state of a prediction.  Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/predictions/gm3qorzdhgbfurvjtvhg6dckhu &#x60;&#x60;&#x60;  The response will be the prediction object:  &#x60;&#x60;&#x60;json {   \&quot;id\&quot;: \&quot;gm3qorzdhgbfurvjtvhg6dckhu\&quot;,   \&quot;model\&quot;: \&quot;replicate/hello-world\&quot;,   \&quot;version\&quot;: \&quot;5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa\&quot;,   \&quot;input\&quot;: {     \&quot;text\&quot;: \&quot;Alice\&quot;   },   \&quot;logs\&quot;: \&quot;\&quot;,   \&quot;output\&quot;: \&quot;hello Alice\&quot;,   \&quot;error\&quot;: null,   \&quot;status\&quot;: \&quot;succeeded\&quot;,   \&quot;created_at\&quot;: \&quot;2023-09-08T16:19:34.765994Z\&quot;,   \&quot;started_at\&quot;: \&quot;2023-09-08T16:19:34.779176Z\&quot;,   \&quot;completed_at\&quot;: \&quot;2023-09-08T16:19:34.791859Z\&quot;,   \&quot;metrics\&quot;: {     \&quot;predict_time\&quot;: 0.012683   },   \&quot;urls\&quot;: {     \&quot;cancel\&quot;: \&quot;https://api.replicate.com/v1/predictions/gm3qorzdhgbfurvjtvhg6dckhu/cancel\&quot;,     \&quot;get\&quot;: \&quot;https://api.replicate.com/v1/predictions/gm3qorzdhgbfurvjtvhg6dckhu\&quot;   } } &#x60;&#x60;&#x60;  &#x60;status&#x60; will be one of:  - &#x60;starting&#x60;: the prediction is starting up. If this status lasts longer than a few seconds, then it&#39;s typically because a new worker is being started to run the prediction. - &#x60;processing&#x60;: the &#x60;predict()&#x60; method of the model is currently running. - &#x60;succeeded&#x60;: the prediction completed successfully. - &#x60;failed&#x60;: the prediction encountered an error during processing. - &#x60;canceled&#x60;: the prediction was canceled by its creator.  In the case of success, &#x60;output&#x60; will be an object containing the output of the model. Any files will be represented as HTTPS URLs. You&#39;ll need to pass the &#x60;Authorization&#x60; header to request them.  In the case of failure, &#x60;error&#x60; will contain the error encountered during the prediction.  Terminated predictions (with a status of &#x60;succeeded&#x60;, &#x60;failed&#x60;, or &#x60;canceled&#x60;) will include a &#x60;metrics&#x60; object with a &#x60;predict_time&#x60; property showing the amount of CPU or GPU time, in seconds, that the prediction used while running. It won&#39;t include time waiting for the prediction to start.  Input and output (including any files) are automatically deleted after an hour, so you must save a copy of any files in the output if you&#39;d like to continue using them.  Output files are served by &#x60;replicate.delivery&#x60; and its subdomains. If you use an allow list of external domains for your assets, add &#x60;replicate.delivery&#x60; and &#x60;*.replicate.delivery&#x60; to it. 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="predictionId">The ID of the prediction to get. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void PredictionsGet(string predictionId, int operationIndex = 0)
        {
            PredictionsGetWithHttpInfo(predictionId);
        }

        /// <summary>
        /// Get a prediction Get the current state of a prediction.  Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/predictions/gm3qorzdhgbfurvjtvhg6dckhu &#x60;&#x60;&#x60;  The response will be the prediction object:  &#x60;&#x60;&#x60;json {   \&quot;id\&quot;: \&quot;gm3qorzdhgbfurvjtvhg6dckhu\&quot;,   \&quot;model\&quot;: \&quot;replicate/hello-world\&quot;,   \&quot;version\&quot;: \&quot;5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa\&quot;,   \&quot;input\&quot;: {     \&quot;text\&quot;: \&quot;Alice\&quot;   },   \&quot;logs\&quot;: \&quot;\&quot;,   \&quot;output\&quot;: \&quot;hello Alice\&quot;,   \&quot;error\&quot;: null,   \&quot;status\&quot;: \&quot;succeeded\&quot;,   \&quot;created_at\&quot;: \&quot;2023-09-08T16:19:34.765994Z\&quot;,   \&quot;started_at\&quot;: \&quot;2023-09-08T16:19:34.779176Z\&quot;,   \&quot;completed_at\&quot;: \&quot;2023-09-08T16:19:34.791859Z\&quot;,   \&quot;metrics\&quot;: {     \&quot;predict_time\&quot;: 0.012683   },   \&quot;urls\&quot;: {     \&quot;cancel\&quot;: \&quot;https://api.replicate.com/v1/predictions/gm3qorzdhgbfurvjtvhg6dckhu/cancel\&quot;,     \&quot;get\&quot;: \&quot;https://api.replicate.com/v1/predictions/gm3qorzdhgbfurvjtvhg6dckhu\&quot;   } } &#x60;&#x60;&#x60;  &#x60;status&#x60; will be one of:  - &#x60;starting&#x60;: the prediction is starting up. If this status lasts longer than a few seconds, then it&#39;s typically because a new worker is being started to run the prediction. - &#x60;processing&#x60;: the &#x60;predict()&#x60; method of the model is currently running. - &#x60;succeeded&#x60;: the prediction completed successfully. - &#x60;failed&#x60;: the prediction encountered an error during processing. - &#x60;canceled&#x60;: the prediction was canceled by its creator.  In the case of success, &#x60;output&#x60; will be an object containing the output of the model. Any files will be represented as HTTPS URLs. You&#39;ll need to pass the &#x60;Authorization&#x60; header to request them.  In the case of failure, &#x60;error&#x60; will contain the error encountered during the prediction.  Terminated predictions (with a status of &#x60;succeeded&#x60;, &#x60;failed&#x60;, or &#x60;canceled&#x60;) will include a &#x60;metrics&#x60; object with a &#x60;predict_time&#x60; property showing the amount of CPU or GPU time, in seconds, that the prediction used while running. It won&#39;t include time waiting for the prediction to start.  Input and output (including any files) are automatically deleted after an hour, so you must save a copy of any files in the output if you&#39;d like to continue using them.  Output files are served by &#x60;replicate.delivery&#x60; and its subdomains. If you use an allow list of external domains for your assets, add &#x60;replicate.delivery&#x60; and &#x60;*.replicate.delivery&#x60; to it. 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="predictionId">The ID of the prediction to get. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public dotnetReplicate.Client.ApiResponse<Object> PredictionsGetWithHttpInfo(string predictionId, int operationIndex = 0)
        {
            // verify the required parameter 'predictionId' is set
            if (predictionId == null)
            {
                throw new dotnetReplicate.Client.ApiException(400, "Missing required parameter 'predictionId' when calling DefaultApi->PredictionsGet");
            }

            dotnetReplicate.Client.RequestOptions localVarRequestOptions = new dotnetReplicate.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };

            var localVarContentType = dotnetReplicate.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = dotnetReplicate.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("prediction_id", dotnetReplicate.Client.ClientUtils.ParameterToString(predictionId)); // path parameter

            localVarRequestOptions.Operation = "DefaultApi.PredictionsGet";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Get<Object>("/predictions/{prediction_id}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PredictionsGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a prediction Get the current state of a prediction.  Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/predictions/gm3qorzdhgbfurvjtvhg6dckhu &#x60;&#x60;&#x60;  The response will be the prediction object:  &#x60;&#x60;&#x60;json {   \&quot;id\&quot;: \&quot;gm3qorzdhgbfurvjtvhg6dckhu\&quot;,   \&quot;model\&quot;: \&quot;replicate/hello-world\&quot;,   \&quot;version\&quot;: \&quot;5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa\&quot;,   \&quot;input\&quot;: {     \&quot;text\&quot;: \&quot;Alice\&quot;   },   \&quot;logs\&quot;: \&quot;\&quot;,   \&quot;output\&quot;: \&quot;hello Alice\&quot;,   \&quot;error\&quot;: null,   \&quot;status\&quot;: \&quot;succeeded\&quot;,   \&quot;created_at\&quot;: \&quot;2023-09-08T16:19:34.765994Z\&quot;,   \&quot;started_at\&quot;: \&quot;2023-09-08T16:19:34.779176Z\&quot;,   \&quot;completed_at\&quot;: \&quot;2023-09-08T16:19:34.791859Z\&quot;,   \&quot;metrics\&quot;: {     \&quot;predict_time\&quot;: 0.012683   },   \&quot;urls\&quot;: {     \&quot;cancel\&quot;: \&quot;https://api.replicate.com/v1/predictions/gm3qorzdhgbfurvjtvhg6dckhu/cancel\&quot;,     \&quot;get\&quot;: \&quot;https://api.replicate.com/v1/predictions/gm3qorzdhgbfurvjtvhg6dckhu\&quot;   } } &#x60;&#x60;&#x60;  &#x60;status&#x60; will be one of:  - &#x60;starting&#x60;: the prediction is starting up. If this status lasts longer than a few seconds, then it&#39;s typically because a new worker is being started to run the prediction. - &#x60;processing&#x60;: the &#x60;predict()&#x60; method of the model is currently running. - &#x60;succeeded&#x60;: the prediction completed successfully. - &#x60;failed&#x60;: the prediction encountered an error during processing. - &#x60;canceled&#x60;: the prediction was canceled by its creator.  In the case of success, &#x60;output&#x60; will be an object containing the output of the model. Any files will be represented as HTTPS URLs. You&#39;ll need to pass the &#x60;Authorization&#x60; header to request them.  In the case of failure, &#x60;error&#x60; will contain the error encountered during the prediction.  Terminated predictions (with a status of &#x60;succeeded&#x60;, &#x60;failed&#x60;, or &#x60;canceled&#x60;) will include a &#x60;metrics&#x60; object with a &#x60;predict_time&#x60; property showing the amount of CPU or GPU time, in seconds, that the prediction used while running. It won&#39;t include time waiting for the prediction to start.  Input and output (including any files) are automatically deleted after an hour, so you must save a copy of any files in the output if you&#39;d like to continue using them.  Output files are served by &#x60;replicate.delivery&#x60; and its subdomains. If you use an allow list of external domains for your assets, add &#x60;replicate.delivery&#x60; and &#x60;*.replicate.delivery&#x60; to it. 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="predictionId">The ID of the prediction to get. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PredictionsGetAsync(string predictionId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await PredictionsGetWithHttpInfoAsync(predictionId, operationIndex, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a prediction Get the current state of a prediction.  Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/predictions/gm3qorzdhgbfurvjtvhg6dckhu &#x60;&#x60;&#x60;  The response will be the prediction object:  &#x60;&#x60;&#x60;json {   \&quot;id\&quot;: \&quot;gm3qorzdhgbfurvjtvhg6dckhu\&quot;,   \&quot;model\&quot;: \&quot;replicate/hello-world\&quot;,   \&quot;version\&quot;: \&quot;5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa\&quot;,   \&quot;input\&quot;: {     \&quot;text\&quot;: \&quot;Alice\&quot;   },   \&quot;logs\&quot;: \&quot;\&quot;,   \&quot;output\&quot;: \&quot;hello Alice\&quot;,   \&quot;error\&quot;: null,   \&quot;status\&quot;: \&quot;succeeded\&quot;,   \&quot;created_at\&quot;: \&quot;2023-09-08T16:19:34.765994Z\&quot;,   \&quot;started_at\&quot;: \&quot;2023-09-08T16:19:34.779176Z\&quot;,   \&quot;completed_at\&quot;: \&quot;2023-09-08T16:19:34.791859Z\&quot;,   \&quot;metrics\&quot;: {     \&quot;predict_time\&quot;: 0.012683   },   \&quot;urls\&quot;: {     \&quot;cancel\&quot;: \&quot;https://api.replicate.com/v1/predictions/gm3qorzdhgbfurvjtvhg6dckhu/cancel\&quot;,     \&quot;get\&quot;: \&quot;https://api.replicate.com/v1/predictions/gm3qorzdhgbfurvjtvhg6dckhu\&quot;   } } &#x60;&#x60;&#x60;  &#x60;status&#x60; will be one of:  - &#x60;starting&#x60;: the prediction is starting up. If this status lasts longer than a few seconds, then it&#39;s typically because a new worker is being started to run the prediction. - &#x60;processing&#x60;: the &#x60;predict()&#x60; method of the model is currently running. - &#x60;succeeded&#x60;: the prediction completed successfully. - &#x60;failed&#x60;: the prediction encountered an error during processing. - &#x60;canceled&#x60;: the prediction was canceled by its creator.  In the case of success, &#x60;output&#x60; will be an object containing the output of the model. Any files will be represented as HTTPS URLs. You&#39;ll need to pass the &#x60;Authorization&#x60; header to request them.  In the case of failure, &#x60;error&#x60; will contain the error encountered during the prediction.  Terminated predictions (with a status of &#x60;succeeded&#x60;, &#x60;failed&#x60;, or &#x60;canceled&#x60;) will include a &#x60;metrics&#x60; object with a &#x60;predict_time&#x60; property showing the amount of CPU or GPU time, in seconds, that the prediction used while running. It won&#39;t include time waiting for the prediction to start.  Input and output (including any files) are automatically deleted after an hour, so you must save a copy of any files in the output if you&#39;d like to continue using them.  Output files are served by &#x60;replicate.delivery&#x60; and its subdomains. If you use an allow list of external domains for your assets, add &#x60;replicate.delivery&#x60; and &#x60;*.replicate.delivery&#x60; to it. 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="predictionId">The ID of the prediction to get. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<dotnetReplicate.Client.ApiResponse<Object>> PredictionsGetWithHttpInfoAsync(string predictionId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'predictionId' is set
            if (predictionId == null)
            {
                throw new dotnetReplicate.Client.ApiException(400, "Missing required parameter 'predictionId' when calling DefaultApi->PredictionsGet");
            }


            dotnetReplicate.Client.RequestOptions localVarRequestOptions = new dotnetReplicate.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };

            var localVarContentType = dotnetReplicate.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = dotnetReplicate.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("prediction_id", dotnetReplicate.Client.ClientUtils.ParameterToString(predictionId)); // path parameter

            localVarRequestOptions.Operation = "DefaultApi.PredictionsGet";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<Object>("/predictions/{prediction_id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PredictionsGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// List predictions Get a paginated list of predictions that you&#39;ve created. This will include predictions created from the API and the website. It will return 100 records per page.  Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/predictions &#x60;&#x60;&#x60;  The response will be a paginated JSON array of prediction objects, sorted with the most recent prediction first:  &#x60;&#x60;&#x60;json {   \&quot;next\&quot;: null,   \&quot;previous\&quot;: null,   \&quot;results\&quot;: [     {       \&quot;completed_at\&quot;: \&quot;2023-09-08T16:19:34.791859Z\&quot;,       \&quot;created_at\&quot;: \&quot;2023-09-08T16:19:34.907244Z\&quot;,       \&quot;error\&quot;: null,       \&quot;id\&quot;: \&quot;gm3qorzdhgbfurvjtvhg6dckhu\&quot;,       \&quot;input\&quot;: {         \&quot;text\&quot;: \&quot;Alice\&quot;       },       \&quot;metrics\&quot;: {         \&quot;predict_time\&quot;: 0.012683       },       \&quot;output\&quot;: \&quot;hello Alice\&quot;,       \&quot;started_at\&quot;: \&quot;2023-09-08T16:19:34.779176Z\&quot;,       \&quot;source\&quot;: \&quot;api\&quot;,       \&quot;status\&quot;: \&quot;succeeded\&quot;,       \&quot;urls\&quot;: {         \&quot;get\&quot;: \&quot;https://api.replicate.com/v1/predictions/gm3qorzdhgbfurvjtvhg6dckhu\&quot;,         \&quot;cancel\&quot;: \&quot;https://api.replicate.com/v1/predictions/gm3qorzdhgbfurvjtvhg6dckhu/cancel\&quot;       },       \&quot;model\&quot;: \&quot;replicate/hello-world\&quot;,       \&quot;version\&quot;: \&quot;5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa\&quot;,     }   ] } &#x60;&#x60;&#x60;  &#x60;id&#x60; will be the unique ID of the prediction.  &#x60;source&#x60; will indicate how the prediction was created. Possible values are &#x60;web&#x60; or &#x60;api&#x60;.  &#x60;status&#x60; will be the status of the prediction. Refer to [get a single prediction](#predictions.get) for possible values.  &#x60;urls&#x60; will be a convenience object that can be used to construct new API requests for the given prediction.  &#x60;model&#x60; will be the model identifier string in the format of &#x60;{model_owner}/{model_name}&#x60;.  &#x60;version&#x60; will be the unique ID of model version used to create the prediction. 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void PredictionsList(int operationIndex = 0)
        {
            PredictionsListWithHttpInfo();
        }

        /// <summary>
        /// List predictions Get a paginated list of predictions that you&#39;ve created. This will include predictions created from the API and the website. It will return 100 records per page.  Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/predictions &#x60;&#x60;&#x60;  The response will be a paginated JSON array of prediction objects, sorted with the most recent prediction first:  &#x60;&#x60;&#x60;json {   \&quot;next\&quot;: null,   \&quot;previous\&quot;: null,   \&quot;results\&quot;: [     {       \&quot;completed_at\&quot;: \&quot;2023-09-08T16:19:34.791859Z\&quot;,       \&quot;created_at\&quot;: \&quot;2023-09-08T16:19:34.907244Z\&quot;,       \&quot;error\&quot;: null,       \&quot;id\&quot;: \&quot;gm3qorzdhgbfurvjtvhg6dckhu\&quot;,       \&quot;input\&quot;: {         \&quot;text\&quot;: \&quot;Alice\&quot;       },       \&quot;metrics\&quot;: {         \&quot;predict_time\&quot;: 0.012683       },       \&quot;output\&quot;: \&quot;hello Alice\&quot;,       \&quot;started_at\&quot;: \&quot;2023-09-08T16:19:34.779176Z\&quot;,       \&quot;source\&quot;: \&quot;api\&quot;,       \&quot;status\&quot;: \&quot;succeeded\&quot;,       \&quot;urls\&quot;: {         \&quot;get\&quot;: \&quot;https://api.replicate.com/v1/predictions/gm3qorzdhgbfurvjtvhg6dckhu\&quot;,         \&quot;cancel\&quot;: \&quot;https://api.replicate.com/v1/predictions/gm3qorzdhgbfurvjtvhg6dckhu/cancel\&quot;       },       \&quot;model\&quot;: \&quot;replicate/hello-world\&quot;,       \&quot;version\&quot;: \&quot;5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa\&quot;,     }   ] } &#x60;&#x60;&#x60;  &#x60;id&#x60; will be the unique ID of the prediction.  &#x60;source&#x60; will indicate how the prediction was created. Possible values are &#x60;web&#x60; or &#x60;api&#x60;.  &#x60;status&#x60; will be the status of the prediction. Refer to [get a single prediction](#predictions.get) for possible values.  &#x60;urls&#x60; will be a convenience object that can be used to construct new API requests for the given prediction.  &#x60;model&#x60; will be the model identifier string in the format of &#x60;{model_owner}/{model_name}&#x60;.  &#x60;version&#x60; will be the unique ID of model version used to create the prediction. 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public dotnetReplicate.Client.ApiResponse<Object> PredictionsListWithHttpInfo(int operationIndex = 0)
        {
            dotnetReplicate.Client.RequestOptions localVarRequestOptions = new dotnetReplicate.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };

            var localVarContentType = dotnetReplicate.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = dotnetReplicate.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }


            localVarRequestOptions.Operation = "DefaultApi.PredictionsList";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Get<Object>("/predictions", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PredictionsList", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// List predictions Get a paginated list of predictions that you&#39;ve created. This will include predictions created from the API and the website. It will return 100 records per page.  Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/predictions &#x60;&#x60;&#x60;  The response will be a paginated JSON array of prediction objects, sorted with the most recent prediction first:  &#x60;&#x60;&#x60;json {   \&quot;next\&quot;: null,   \&quot;previous\&quot;: null,   \&quot;results\&quot;: [     {       \&quot;completed_at\&quot;: \&quot;2023-09-08T16:19:34.791859Z\&quot;,       \&quot;created_at\&quot;: \&quot;2023-09-08T16:19:34.907244Z\&quot;,       \&quot;error\&quot;: null,       \&quot;id\&quot;: \&quot;gm3qorzdhgbfurvjtvhg6dckhu\&quot;,       \&quot;input\&quot;: {         \&quot;text\&quot;: \&quot;Alice\&quot;       },       \&quot;metrics\&quot;: {         \&quot;predict_time\&quot;: 0.012683       },       \&quot;output\&quot;: \&quot;hello Alice\&quot;,       \&quot;started_at\&quot;: \&quot;2023-09-08T16:19:34.779176Z\&quot;,       \&quot;source\&quot;: \&quot;api\&quot;,       \&quot;status\&quot;: \&quot;succeeded\&quot;,       \&quot;urls\&quot;: {         \&quot;get\&quot;: \&quot;https://api.replicate.com/v1/predictions/gm3qorzdhgbfurvjtvhg6dckhu\&quot;,         \&quot;cancel\&quot;: \&quot;https://api.replicate.com/v1/predictions/gm3qorzdhgbfurvjtvhg6dckhu/cancel\&quot;       },       \&quot;model\&quot;: \&quot;replicate/hello-world\&quot;,       \&quot;version\&quot;: \&quot;5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa\&quot;,     }   ] } &#x60;&#x60;&#x60;  &#x60;id&#x60; will be the unique ID of the prediction.  &#x60;source&#x60; will indicate how the prediction was created. Possible values are &#x60;web&#x60; or &#x60;api&#x60;.  &#x60;status&#x60; will be the status of the prediction. Refer to [get a single prediction](#predictions.get) for possible values.  &#x60;urls&#x60; will be a convenience object that can be used to construct new API requests for the given prediction.  &#x60;model&#x60; will be the model identifier string in the format of &#x60;{model_owner}/{model_name}&#x60;.  &#x60;version&#x60; will be the unique ID of model version used to create the prediction. 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PredictionsListAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await PredictionsListWithHttpInfoAsync(operationIndex, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// List predictions Get a paginated list of predictions that you&#39;ve created. This will include predictions created from the API and the website. It will return 100 records per page.  Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/predictions &#x60;&#x60;&#x60;  The response will be a paginated JSON array of prediction objects, sorted with the most recent prediction first:  &#x60;&#x60;&#x60;json {   \&quot;next\&quot;: null,   \&quot;previous\&quot;: null,   \&quot;results\&quot;: [     {       \&quot;completed_at\&quot;: \&quot;2023-09-08T16:19:34.791859Z\&quot;,       \&quot;created_at\&quot;: \&quot;2023-09-08T16:19:34.907244Z\&quot;,       \&quot;error\&quot;: null,       \&quot;id\&quot;: \&quot;gm3qorzdhgbfurvjtvhg6dckhu\&quot;,       \&quot;input\&quot;: {         \&quot;text\&quot;: \&quot;Alice\&quot;       },       \&quot;metrics\&quot;: {         \&quot;predict_time\&quot;: 0.012683       },       \&quot;output\&quot;: \&quot;hello Alice\&quot;,       \&quot;started_at\&quot;: \&quot;2023-09-08T16:19:34.779176Z\&quot;,       \&quot;source\&quot;: \&quot;api\&quot;,       \&quot;status\&quot;: \&quot;succeeded\&quot;,       \&quot;urls\&quot;: {         \&quot;get\&quot;: \&quot;https://api.replicate.com/v1/predictions/gm3qorzdhgbfurvjtvhg6dckhu\&quot;,         \&quot;cancel\&quot;: \&quot;https://api.replicate.com/v1/predictions/gm3qorzdhgbfurvjtvhg6dckhu/cancel\&quot;       },       \&quot;model\&quot;: \&quot;replicate/hello-world\&quot;,       \&quot;version\&quot;: \&quot;5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa\&quot;,     }   ] } &#x60;&#x60;&#x60;  &#x60;id&#x60; will be the unique ID of the prediction.  &#x60;source&#x60; will indicate how the prediction was created. Possible values are &#x60;web&#x60; or &#x60;api&#x60;.  &#x60;status&#x60; will be the status of the prediction. Refer to [get a single prediction](#predictions.get) for possible values.  &#x60;urls&#x60; will be a convenience object that can be used to construct new API requests for the given prediction.  &#x60;model&#x60; will be the model identifier string in the format of &#x60;{model_owner}/{model_name}&#x60;.  &#x60;version&#x60; will be the unique ID of model version used to create the prediction. 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<dotnetReplicate.Client.ApiResponse<Object>> PredictionsListWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            dotnetReplicate.Client.RequestOptions localVarRequestOptions = new dotnetReplicate.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };

            var localVarContentType = dotnetReplicate.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = dotnetReplicate.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }


            localVarRequestOptions.Operation = "DefaultApi.PredictionsList";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<Object>("/predictions", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PredictionsList", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Cancel a training 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trainingId">The ID of the training you want to cancel. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void TrainingsCancel(string trainingId, int operationIndex = 0)
        {
            TrainingsCancelWithHttpInfo(trainingId);
        }

        /// <summary>
        /// Cancel a training 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trainingId">The ID of the training you want to cancel. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public dotnetReplicate.Client.ApiResponse<Object> TrainingsCancelWithHttpInfo(string trainingId, int operationIndex = 0)
        {
            // verify the required parameter 'trainingId' is set
            if (trainingId == null)
            {
                throw new dotnetReplicate.Client.ApiException(400, "Missing required parameter 'trainingId' when calling DefaultApi->TrainingsCancel");
            }

            dotnetReplicate.Client.RequestOptions localVarRequestOptions = new dotnetReplicate.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };

            var localVarContentType = dotnetReplicate.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = dotnetReplicate.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("training_id", dotnetReplicate.Client.ClientUtils.ParameterToString(trainingId)); // path parameter

            localVarRequestOptions.Operation = "DefaultApi.TrainingsCancel";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Post<Object>("/trainings/{training_id}/cancel", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("TrainingsCancel", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Cancel a training 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trainingId">The ID of the training you want to cancel. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task TrainingsCancelAsync(string trainingId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await TrainingsCancelWithHttpInfoAsync(trainingId, operationIndex, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Cancel a training 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trainingId">The ID of the training you want to cancel. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<dotnetReplicate.Client.ApiResponse<Object>> TrainingsCancelWithHttpInfoAsync(string trainingId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'trainingId' is set
            if (trainingId == null)
            {
                throw new dotnetReplicate.Client.ApiException(400, "Missing required parameter 'trainingId' when calling DefaultApi->TrainingsCancel");
            }


            dotnetReplicate.Client.RequestOptions localVarRequestOptions = new dotnetReplicate.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };

            var localVarContentType = dotnetReplicate.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = dotnetReplicate.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("training_id", dotnetReplicate.Client.ClientUtils.ParameterToString(trainingId)); // path parameter

            localVarRequestOptions.Operation = "DefaultApi.TrainingsCancel";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<Object>("/trainings/{training_id}/cancel", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("TrainingsCancel", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create a training Start a new training of the model version you specify.  Example request body:  &#x60;&#x60;&#x60;json {   \&quot;destination\&quot;: \&quot;{new_owner}/{new_name}\&quot;,   \&quot;input\&quot;: {     \&quot;train_data\&quot;: \&quot;https://example.com/my-input-images.zip\&quot;,   },   \&quot;webhook\&quot;: \&quot;https://example.com/my-webhook\&quot;, } &#x60;&#x60;&#x60;  Example cURL request:  &#x60;&#x60;&#x60;console curl -s -X POST \\   -d &#39;{\&quot;destination\&quot;: \&quot;{new_owner}/{new_name}\&quot;, \&quot;input\&quot;: {\&quot;input_images\&quot;: \&quot;https://example.com/my-input-images.zip\&quot;}}&#39; \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   -H &#39;Content-Type: application/json&#39; \\   https://api.replicate.com/v1/models/stability-ai/sdxl/versions/da77bc59ee60423279fd632efb4795ab731d9e3ca9705ef3341091fb989b7eaf/trainings &#x60;&#x60;&#x60;  The response will be the training object:  &#x60;&#x60;&#x60;json {   \&quot;id\&quot;: \&quot;zz4ibbonubfz7carwiefibzgga\&quot;,   \&quot;model\&quot;: \&quot;stability-ai/sdxl\&quot;,   \&quot;version\&quot;: \&quot;da77bc59ee60423279fd632efb4795ab731d9e3ca9705ef3341091fb989b7eaf\&quot;,   \&quot;input\&quot;: {     \&quot;input_images\&quot;: \&quot;https://example.com/my-input-images.zip\&quot;   },   \&quot;logs\&quot;: \&quot;\&quot;,   \&quot;error\&quot;: null,   \&quot;status\&quot;: \&quot;starting\&quot;,   \&quot;created_at\&quot;: \&quot;2023-09-08T16:32:56.990893084Z\&quot;,   \&quot;urls\&quot;: {     \&quot;cancel\&quot;: \&quot;https://api.replicate.com/v1/predictions/zz4ibbonubfz7carwiefibzgga/cancel\&quot;,     \&quot;get\&quot;: \&quot;https://api.replicate.com/v1/predictions/zz4ibbonubfz7carwiefibzgga\&quot;   } } &#x60;&#x60;&#x60;  As models can take several minutes or more to train, the result will not be available immediately. To get the final result of the training you should either provide a &#x60;webhook&#x60; HTTPS URL for us to call when the results are ready, or poll the [get a training](#trainings.get) endpoint until it has finished.  When a training completes, it creates a new [version](https://replicate.com/docs/how-does-replicate-work#terminology) of the model at the specified destination.  To find some models to train on, check out the [trainable language models collection](https://replicate.com/collections/trainable-language-models). 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelOwner">The name of the user or organization that owns the model. </param>
        /// <param name="modelName">The name of the model. </param>
        /// <param name="versionId">The ID of the version. </param>
        /// <param name="trainingsCreateRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void TrainingsCreate(string modelOwner, string modelName, string versionId, TrainingsCreateRequest? trainingsCreateRequest = default(TrainingsCreateRequest?), int operationIndex = 0)
        {
            TrainingsCreateWithHttpInfo(modelOwner, modelName, versionId, trainingsCreateRequest);
        }

        /// <summary>
        /// Create a training Start a new training of the model version you specify.  Example request body:  &#x60;&#x60;&#x60;json {   \&quot;destination\&quot;: \&quot;{new_owner}/{new_name}\&quot;,   \&quot;input\&quot;: {     \&quot;train_data\&quot;: \&quot;https://example.com/my-input-images.zip\&quot;,   },   \&quot;webhook\&quot;: \&quot;https://example.com/my-webhook\&quot;, } &#x60;&#x60;&#x60;  Example cURL request:  &#x60;&#x60;&#x60;console curl -s -X POST \\   -d &#39;{\&quot;destination\&quot;: \&quot;{new_owner}/{new_name}\&quot;, \&quot;input\&quot;: {\&quot;input_images\&quot;: \&quot;https://example.com/my-input-images.zip\&quot;}}&#39; \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   -H &#39;Content-Type: application/json&#39; \\   https://api.replicate.com/v1/models/stability-ai/sdxl/versions/da77bc59ee60423279fd632efb4795ab731d9e3ca9705ef3341091fb989b7eaf/trainings &#x60;&#x60;&#x60;  The response will be the training object:  &#x60;&#x60;&#x60;json {   \&quot;id\&quot;: \&quot;zz4ibbonubfz7carwiefibzgga\&quot;,   \&quot;model\&quot;: \&quot;stability-ai/sdxl\&quot;,   \&quot;version\&quot;: \&quot;da77bc59ee60423279fd632efb4795ab731d9e3ca9705ef3341091fb989b7eaf\&quot;,   \&quot;input\&quot;: {     \&quot;input_images\&quot;: \&quot;https://example.com/my-input-images.zip\&quot;   },   \&quot;logs\&quot;: \&quot;\&quot;,   \&quot;error\&quot;: null,   \&quot;status\&quot;: \&quot;starting\&quot;,   \&quot;created_at\&quot;: \&quot;2023-09-08T16:32:56.990893084Z\&quot;,   \&quot;urls\&quot;: {     \&quot;cancel\&quot;: \&quot;https://api.replicate.com/v1/predictions/zz4ibbonubfz7carwiefibzgga/cancel\&quot;,     \&quot;get\&quot;: \&quot;https://api.replicate.com/v1/predictions/zz4ibbonubfz7carwiefibzgga\&quot;   } } &#x60;&#x60;&#x60;  As models can take several minutes or more to train, the result will not be available immediately. To get the final result of the training you should either provide a &#x60;webhook&#x60; HTTPS URL for us to call when the results are ready, or poll the [get a training](#trainings.get) endpoint until it has finished.  When a training completes, it creates a new [version](https://replicate.com/docs/how-does-replicate-work#terminology) of the model at the specified destination.  To find some models to train on, check out the [trainable language models collection](https://replicate.com/collections/trainable-language-models). 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelOwner">The name of the user or organization that owns the model. </param>
        /// <param name="modelName">The name of the model. </param>
        /// <param name="versionId">The ID of the version. </param>
        /// <param name="trainingsCreateRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public dotnetReplicate.Client.ApiResponse<Object> TrainingsCreateWithHttpInfo(string modelOwner, string modelName, string versionId, TrainingsCreateRequest? trainingsCreateRequest = default(TrainingsCreateRequest?), int operationIndex = 0)
        {
            // verify the required parameter 'modelOwner' is set
            if (modelOwner == null)
            {
                throw new dotnetReplicate.Client.ApiException(400, "Missing required parameter 'modelOwner' when calling DefaultApi->TrainingsCreate");
            }

            // verify the required parameter 'modelName' is set
            if (modelName == null)
            {
                throw new dotnetReplicate.Client.ApiException(400, "Missing required parameter 'modelName' when calling DefaultApi->TrainingsCreate");
            }

            // verify the required parameter 'versionId' is set
            if (versionId == null)
            {
                throw new dotnetReplicate.Client.ApiException(400, "Missing required parameter 'versionId' when calling DefaultApi->TrainingsCreate");
            }

            dotnetReplicate.Client.RequestOptions localVarRequestOptions = new dotnetReplicate.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };

            var localVarContentType = dotnetReplicate.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = dotnetReplicate.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("model_owner", dotnetReplicate.Client.ClientUtils.ParameterToString(modelOwner)); // path parameter
            localVarRequestOptions.PathParameters.Add("model_name", dotnetReplicate.Client.ClientUtils.ParameterToString(modelName)); // path parameter
            localVarRequestOptions.PathParameters.Add("version_id", dotnetReplicate.Client.ClientUtils.ParameterToString(versionId)); // path parameter
            localVarRequestOptions.Data = trainingsCreateRequest;

            localVarRequestOptions.Operation = "DefaultApi.TrainingsCreate";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Post<Object>("/models/{model_owner}/{model_name}/versions/{version_id}/trainings", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("TrainingsCreate", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create a training Start a new training of the model version you specify.  Example request body:  &#x60;&#x60;&#x60;json {   \&quot;destination\&quot;: \&quot;{new_owner}/{new_name}\&quot;,   \&quot;input\&quot;: {     \&quot;train_data\&quot;: \&quot;https://example.com/my-input-images.zip\&quot;,   },   \&quot;webhook\&quot;: \&quot;https://example.com/my-webhook\&quot;, } &#x60;&#x60;&#x60;  Example cURL request:  &#x60;&#x60;&#x60;console curl -s -X POST \\   -d &#39;{\&quot;destination\&quot;: \&quot;{new_owner}/{new_name}\&quot;, \&quot;input\&quot;: {\&quot;input_images\&quot;: \&quot;https://example.com/my-input-images.zip\&quot;}}&#39; \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   -H &#39;Content-Type: application/json&#39; \\   https://api.replicate.com/v1/models/stability-ai/sdxl/versions/da77bc59ee60423279fd632efb4795ab731d9e3ca9705ef3341091fb989b7eaf/trainings &#x60;&#x60;&#x60;  The response will be the training object:  &#x60;&#x60;&#x60;json {   \&quot;id\&quot;: \&quot;zz4ibbonubfz7carwiefibzgga\&quot;,   \&quot;model\&quot;: \&quot;stability-ai/sdxl\&quot;,   \&quot;version\&quot;: \&quot;da77bc59ee60423279fd632efb4795ab731d9e3ca9705ef3341091fb989b7eaf\&quot;,   \&quot;input\&quot;: {     \&quot;input_images\&quot;: \&quot;https://example.com/my-input-images.zip\&quot;   },   \&quot;logs\&quot;: \&quot;\&quot;,   \&quot;error\&quot;: null,   \&quot;status\&quot;: \&quot;starting\&quot;,   \&quot;created_at\&quot;: \&quot;2023-09-08T16:32:56.990893084Z\&quot;,   \&quot;urls\&quot;: {     \&quot;cancel\&quot;: \&quot;https://api.replicate.com/v1/predictions/zz4ibbonubfz7carwiefibzgga/cancel\&quot;,     \&quot;get\&quot;: \&quot;https://api.replicate.com/v1/predictions/zz4ibbonubfz7carwiefibzgga\&quot;   } } &#x60;&#x60;&#x60;  As models can take several minutes or more to train, the result will not be available immediately. To get the final result of the training you should either provide a &#x60;webhook&#x60; HTTPS URL for us to call when the results are ready, or poll the [get a training](#trainings.get) endpoint until it has finished.  When a training completes, it creates a new [version](https://replicate.com/docs/how-does-replicate-work#terminology) of the model at the specified destination.  To find some models to train on, check out the [trainable language models collection](https://replicate.com/collections/trainable-language-models). 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelOwner">The name of the user or organization that owns the model. </param>
        /// <param name="modelName">The name of the model. </param>
        /// <param name="versionId">The ID of the version. </param>
        /// <param name="trainingsCreateRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task TrainingsCreateAsync(string modelOwner, string modelName, string versionId, TrainingsCreateRequest? trainingsCreateRequest = default(TrainingsCreateRequest?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await TrainingsCreateWithHttpInfoAsync(modelOwner, modelName, versionId, trainingsCreateRequest, operationIndex, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Create a training Start a new training of the model version you specify.  Example request body:  &#x60;&#x60;&#x60;json {   \&quot;destination\&quot;: \&quot;{new_owner}/{new_name}\&quot;,   \&quot;input\&quot;: {     \&quot;train_data\&quot;: \&quot;https://example.com/my-input-images.zip\&quot;,   },   \&quot;webhook\&quot;: \&quot;https://example.com/my-webhook\&quot;, } &#x60;&#x60;&#x60;  Example cURL request:  &#x60;&#x60;&#x60;console curl -s -X POST \\   -d &#39;{\&quot;destination\&quot;: \&quot;{new_owner}/{new_name}\&quot;, \&quot;input\&quot;: {\&quot;input_images\&quot;: \&quot;https://example.com/my-input-images.zip\&quot;}}&#39; \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   -H &#39;Content-Type: application/json&#39; \\   https://api.replicate.com/v1/models/stability-ai/sdxl/versions/da77bc59ee60423279fd632efb4795ab731d9e3ca9705ef3341091fb989b7eaf/trainings &#x60;&#x60;&#x60;  The response will be the training object:  &#x60;&#x60;&#x60;json {   \&quot;id\&quot;: \&quot;zz4ibbonubfz7carwiefibzgga\&quot;,   \&quot;model\&quot;: \&quot;stability-ai/sdxl\&quot;,   \&quot;version\&quot;: \&quot;da77bc59ee60423279fd632efb4795ab731d9e3ca9705ef3341091fb989b7eaf\&quot;,   \&quot;input\&quot;: {     \&quot;input_images\&quot;: \&quot;https://example.com/my-input-images.zip\&quot;   },   \&quot;logs\&quot;: \&quot;\&quot;,   \&quot;error\&quot;: null,   \&quot;status\&quot;: \&quot;starting\&quot;,   \&quot;created_at\&quot;: \&quot;2023-09-08T16:32:56.990893084Z\&quot;,   \&quot;urls\&quot;: {     \&quot;cancel\&quot;: \&quot;https://api.replicate.com/v1/predictions/zz4ibbonubfz7carwiefibzgga/cancel\&quot;,     \&quot;get\&quot;: \&quot;https://api.replicate.com/v1/predictions/zz4ibbonubfz7carwiefibzgga\&quot;   } } &#x60;&#x60;&#x60;  As models can take several minutes or more to train, the result will not be available immediately. To get the final result of the training you should either provide a &#x60;webhook&#x60; HTTPS URL for us to call when the results are ready, or poll the [get a training](#trainings.get) endpoint until it has finished.  When a training completes, it creates a new [version](https://replicate.com/docs/how-does-replicate-work#terminology) of the model at the specified destination.  To find some models to train on, check out the [trainable language models collection](https://replicate.com/collections/trainable-language-models). 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelOwner">The name of the user or organization that owns the model. </param>
        /// <param name="modelName">The name of the model. </param>
        /// <param name="versionId">The ID of the version. </param>
        /// <param name="trainingsCreateRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<dotnetReplicate.Client.ApiResponse<Object>> TrainingsCreateWithHttpInfoAsync(string modelOwner, string modelName, string versionId, TrainingsCreateRequest? trainingsCreateRequest = default(TrainingsCreateRequest?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'modelOwner' is set
            if (modelOwner == null)
            {
                throw new dotnetReplicate.Client.ApiException(400, "Missing required parameter 'modelOwner' when calling DefaultApi->TrainingsCreate");
            }

            // verify the required parameter 'modelName' is set
            if (modelName == null)
            {
                throw new dotnetReplicate.Client.ApiException(400, "Missing required parameter 'modelName' when calling DefaultApi->TrainingsCreate");
            }

            // verify the required parameter 'versionId' is set
            if (versionId == null)
            {
                throw new dotnetReplicate.Client.ApiException(400, "Missing required parameter 'versionId' when calling DefaultApi->TrainingsCreate");
            }


            dotnetReplicate.Client.RequestOptions localVarRequestOptions = new dotnetReplicate.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };

            var localVarContentType = dotnetReplicate.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = dotnetReplicate.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("model_owner", dotnetReplicate.Client.ClientUtils.ParameterToString(modelOwner)); // path parameter
            localVarRequestOptions.PathParameters.Add("model_name", dotnetReplicate.Client.ClientUtils.ParameterToString(modelName)); // path parameter
            localVarRequestOptions.PathParameters.Add("version_id", dotnetReplicate.Client.ClientUtils.ParameterToString(versionId)); // path parameter
            localVarRequestOptions.Data = trainingsCreateRequest;

            localVarRequestOptions.Operation = "DefaultApi.TrainingsCreate";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<Object>("/models/{model_owner}/{model_name}/versions/{version_id}/trainings", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("TrainingsCreate", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a training Get the current state of a training.  Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/trainings/zz4ibbonubfz7carwiefibzgga &#x60;&#x60;&#x60;  The response will be the training object:  &#x60;&#x60;&#x60;json {   \&quot;completed_at\&quot;: \&quot;2023-09-08T16:41:19.826523Z\&quot;,   \&quot;created_at\&quot;: \&quot;2023-09-08T16:32:57.018467Z\&quot;,   \&quot;error\&quot;: null,   \&quot;id\&quot;: \&quot;zz4ibbonubfz7carwiefibzgga\&quot;,   \&quot;input\&quot;: {     \&quot;input_images\&quot;: \&quot;https://example.com/my-input-images.zip\&quot;   },   \&quot;logs\&quot;: \&quot;...\&quot;,   \&quot;metrics\&quot;: {     \&quot;predict_time\&quot;: 502.713876   },   \&quot;output\&quot;: {     \&quot;version\&quot;: \&quot;...\&quot;,     \&quot;weights\&quot;: \&quot;...\&quot;   },   \&quot;started_at\&quot;: \&quot;2023-09-08T16:32:57.112647Z\&quot;,   \&quot;status\&quot;: \&quot;succeeded\&quot;,   \&quot;urls\&quot;: {     \&quot;get\&quot;: \&quot;https://api.replicate.com/v1/trainings/zz4ibbonubfz7carwiefibzgga\&quot;,     \&quot;cancel\&quot;: \&quot;https://api.replicate.com/v1/trainings/zz4ibbonubfz7carwiefibzgga/cancel\&quot;   },   \&quot;model\&quot;: \&quot;stability-ai/sdxl\&quot;,   \&quot;version\&quot;: \&quot;da77bc59ee60423279fd632efb4795ab731d9e3ca9705ef3341091fb989b7eaf\&quot;, } &#x60;&#x60;&#x60;  &#x60;status&#x60; will be one of:  - &#x60;starting&#x60;: the training is starting up. If this status lasts longer than a few seconds, then it&#39;s typically because a new worker is being started to run the training. - &#x60;processing&#x60;: the &#x60;train()&#x60; method of the model is currently running. - &#x60;succeeded&#x60;: the training completed successfully. - &#x60;failed&#x60;: the training encountered an error during processing. - &#x60;canceled&#x60;: the training was canceled by its creator.  In the case of success, &#x60;output&#x60; will be an object containing the output of the model. Any files will be represented as HTTPS URLs. You&#39;ll need to pass the &#x60;Authorization&#x60; header to request them.  In the case of failure, &#x60;error&#x60; will contain the error encountered during the training.  Terminated trainings (with a status of &#x60;succeeded&#x60;, &#x60;failed&#x60;, or &#x60;canceled&#x60;) will include a &#x60;metrics&#x60; object with a &#x60;predict_time&#x60; property showing the amount of CPU or GPU time, in seconds, that the training used while running. It won&#39;t include time waiting for the training to start. 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trainingId">The ID of the training to get. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void TrainingsGet(string trainingId, int operationIndex = 0)
        {
            TrainingsGetWithHttpInfo(trainingId);
        }

        /// <summary>
        /// Get a training Get the current state of a training.  Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/trainings/zz4ibbonubfz7carwiefibzgga &#x60;&#x60;&#x60;  The response will be the training object:  &#x60;&#x60;&#x60;json {   \&quot;completed_at\&quot;: \&quot;2023-09-08T16:41:19.826523Z\&quot;,   \&quot;created_at\&quot;: \&quot;2023-09-08T16:32:57.018467Z\&quot;,   \&quot;error\&quot;: null,   \&quot;id\&quot;: \&quot;zz4ibbonubfz7carwiefibzgga\&quot;,   \&quot;input\&quot;: {     \&quot;input_images\&quot;: \&quot;https://example.com/my-input-images.zip\&quot;   },   \&quot;logs\&quot;: \&quot;...\&quot;,   \&quot;metrics\&quot;: {     \&quot;predict_time\&quot;: 502.713876   },   \&quot;output\&quot;: {     \&quot;version\&quot;: \&quot;...\&quot;,     \&quot;weights\&quot;: \&quot;...\&quot;   },   \&quot;started_at\&quot;: \&quot;2023-09-08T16:32:57.112647Z\&quot;,   \&quot;status\&quot;: \&quot;succeeded\&quot;,   \&quot;urls\&quot;: {     \&quot;get\&quot;: \&quot;https://api.replicate.com/v1/trainings/zz4ibbonubfz7carwiefibzgga\&quot;,     \&quot;cancel\&quot;: \&quot;https://api.replicate.com/v1/trainings/zz4ibbonubfz7carwiefibzgga/cancel\&quot;   },   \&quot;model\&quot;: \&quot;stability-ai/sdxl\&quot;,   \&quot;version\&quot;: \&quot;da77bc59ee60423279fd632efb4795ab731d9e3ca9705ef3341091fb989b7eaf\&quot;, } &#x60;&#x60;&#x60;  &#x60;status&#x60; will be one of:  - &#x60;starting&#x60;: the training is starting up. If this status lasts longer than a few seconds, then it&#39;s typically because a new worker is being started to run the training. - &#x60;processing&#x60;: the &#x60;train()&#x60; method of the model is currently running. - &#x60;succeeded&#x60;: the training completed successfully. - &#x60;failed&#x60;: the training encountered an error during processing. - &#x60;canceled&#x60;: the training was canceled by its creator.  In the case of success, &#x60;output&#x60; will be an object containing the output of the model. Any files will be represented as HTTPS URLs. You&#39;ll need to pass the &#x60;Authorization&#x60; header to request them.  In the case of failure, &#x60;error&#x60; will contain the error encountered during the training.  Terminated trainings (with a status of &#x60;succeeded&#x60;, &#x60;failed&#x60;, or &#x60;canceled&#x60;) will include a &#x60;metrics&#x60; object with a &#x60;predict_time&#x60; property showing the amount of CPU or GPU time, in seconds, that the training used while running. It won&#39;t include time waiting for the training to start. 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trainingId">The ID of the training to get. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public dotnetReplicate.Client.ApiResponse<Object> TrainingsGetWithHttpInfo(string trainingId, int operationIndex = 0)
        {
            // verify the required parameter 'trainingId' is set
            if (trainingId == null)
            {
                throw new dotnetReplicate.Client.ApiException(400, "Missing required parameter 'trainingId' when calling DefaultApi->TrainingsGet");
            }

            dotnetReplicate.Client.RequestOptions localVarRequestOptions = new dotnetReplicate.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };

            var localVarContentType = dotnetReplicate.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = dotnetReplicate.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("training_id", dotnetReplicate.Client.ClientUtils.ParameterToString(trainingId)); // path parameter

            localVarRequestOptions.Operation = "DefaultApi.TrainingsGet";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Get<Object>("/trainings/{training_id}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("TrainingsGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a training Get the current state of a training.  Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/trainings/zz4ibbonubfz7carwiefibzgga &#x60;&#x60;&#x60;  The response will be the training object:  &#x60;&#x60;&#x60;json {   \&quot;completed_at\&quot;: \&quot;2023-09-08T16:41:19.826523Z\&quot;,   \&quot;created_at\&quot;: \&quot;2023-09-08T16:32:57.018467Z\&quot;,   \&quot;error\&quot;: null,   \&quot;id\&quot;: \&quot;zz4ibbonubfz7carwiefibzgga\&quot;,   \&quot;input\&quot;: {     \&quot;input_images\&quot;: \&quot;https://example.com/my-input-images.zip\&quot;   },   \&quot;logs\&quot;: \&quot;...\&quot;,   \&quot;metrics\&quot;: {     \&quot;predict_time\&quot;: 502.713876   },   \&quot;output\&quot;: {     \&quot;version\&quot;: \&quot;...\&quot;,     \&quot;weights\&quot;: \&quot;...\&quot;   },   \&quot;started_at\&quot;: \&quot;2023-09-08T16:32:57.112647Z\&quot;,   \&quot;status\&quot;: \&quot;succeeded\&quot;,   \&quot;urls\&quot;: {     \&quot;get\&quot;: \&quot;https://api.replicate.com/v1/trainings/zz4ibbonubfz7carwiefibzgga\&quot;,     \&quot;cancel\&quot;: \&quot;https://api.replicate.com/v1/trainings/zz4ibbonubfz7carwiefibzgga/cancel\&quot;   },   \&quot;model\&quot;: \&quot;stability-ai/sdxl\&quot;,   \&quot;version\&quot;: \&quot;da77bc59ee60423279fd632efb4795ab731d9e3ca9705ef3341091fb989b7eaf\&quot;, } &#x60;&#x60;&#x60;  &#x60;status&#x60; will be one of:  - &#x60;starting&#x60;: the training is starting up. If this status lasts longer than a few seconds, then it&#39;s typically because a new worker is being started to run the training. - &#x60;processing&#x60;: the &#x60;train()&#x60; method of the model is currently running. - &#x60;succeeded&#x60;: the training completed successfully. - &#x60;failed&#x60;: the training encountered an error during processing. - &#x60;canceled&#x60;: the training was canceled by its creator.  In the case of success, &#x60;output&#x60; will be an object containing the output of the model. Any files will be represented as HTTPS URLs. You&#39;ll need to pass the &#x60;Authorization&#x60; header to request them.  In the case of failure, &#x60;error&#x60; will contain the error encountered during the training.  Terminated trainings (with a status of &#x60;succeeded&#x60;, &#x60;failed&#x60;, or &#x60;canceled&#x60;) will include a &#x60;metrics&#x60; object with a &#x60;predict_time&#x60; property showing the amount of CPU or GPU time, in seconds, that the training used while running. It won&#39;t include time waiting for the training to start. 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trainingId">The ID of the training to get. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task TrainingsGetAsync(string trainingId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await TrainingsGetWithHttpInfoAsync(trainingId, operationIndex, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a training Get the current state of a training.  Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/trainings/zz4ibbonubfz7carwiefibzgga &#x60;&#x60;&#x60;  The response will be the training object:  &#x60;&#x60;&#x60;json {   \&quot;completed_at\&quot;: \&quot;2023-09-08T16:41:19.826523Z\&quot;,   \&quot;created_at\&quot;: \&quot;2023-09-08T16:32:57.018467Z\&quot;,   \&quot;error\&quot;: null,   \&quot;id\&quot;: \&quot;zz4ibbonubfz7carwiefibzgga\&quot;,   \&quot;input\&quot;: {     \&quot;input_images\&quot;: \&quot;https://example.com/my-input-images.zip\&quot;   },   \&quot;logs\&quot;: \&quot;...\&quot;,   \&quot;metrics\&quot;: {     \&quot;predict_time\&quot;: 502.713876   },   \&quot;output\&quot;: {     \&quot;version\&quot;: \&quot;...\&quot;,     \&quot;weights\&quot;: \&quot;...\&quot;   },   \&quot;started_at\&quot;: \&quot;2023-09-08T16:32:57.112647Z\&quot;,   \&quot;status\&quot;: \&quot;succeeded\&quot;,   \&quot;urls\&quot;: {     \&quot;get\&quot;: \&quot;https://api.replicate.com/v1/trainings/zz4ibbonubfz7carwiefibzgga\&quot;,     \&quot;cancel\&quot;: \&quot;https://api.replicate.com/v1/trainings/zz4ibbonubfz7carwiefibzgga/cancel\&quot;   },   \&quot;model\&quot;: \&quot;stability-ai/sdxl\&quot;,   \&quot;version\&quot;: \&quot;da77bc59ee60423279fd632efb4795ab731d9e3ca9705ef3341091fb989b7eaf\&quot;, } &#x60;&#x60;&#x60;  &#x60;status&#x60; will be one of:  - &#x60;starting&#x60;: the training is starting up. If this status lasts longer than a few seconds, then it&#39;s typically because a new worker is being started to run the training. - &#x60;processing&#x60;: the &#x60;train()&#x60; method of the model is currently running. - &#x60;succeeded&#x60;: the training completed successfully. - &#x60;failed&#x60;: the training encountered an error during processing. - &#x60;canceled&#x60;: the training was canceled by its creator.  In the case of success, &#x60;output&#x60; will be an object containing the output of the model. Any files will be represented as HTTPS URLs. You&#39;ll need to pass the &#x60;Authorization&#x60; header to request them.  In the case of failure, &#x60;error&#x60; will contain the error encountered during the training.  Terminated trainings (with a status of &#x60;succeeded&#x60;, &#x60;failed&#x60;, or &#x60;canceled&#x60;) will include a &#x60;metrics&#x60; object with a &#x60;predict_time&#x60; property showing the amount of CPU or GPU time, in seconds, that the training used while running. It won&#39;t include time waiting for the training to start. 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trainingId">The ID of the training to get. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<dotnetReplicate.Client.ApiResponse<Object>> TrainingsGetWithHttpInfoAsync(string trainingId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'trainingId' is set
            if (trainingId == null)
            {
                throw new dotnetReplicate.Client.ApiException(400, "Missing required parameter 'trainingId' when calling DefaultApi->TrainingsGet");
            }


            dotnetReplicate.Client.RequestOptions localVarRequestOptions = new dotnetReplicate.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };

            var localVarContentType = dotnetReplicate.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = dotnetReplicate.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("training_id", dotnetReplicate.Client.ClientUtils.ParameterToString(trainingId)); // path parameter

            localVarRequestOptions.Operation = "DefaultApi.TrainingsGet";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<Object>("/trainings/{training_id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("TrainingsGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// List trainings Get a paginated list of trainings that you&#39;ve created. This will include trainings created from the API and the website. It will return 100 records per page.  Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/trainings &#x60;&#x60;&#x60;  The response will be a paginated JSON array of training objects, sorted with the most recent training first:  &#x60;&#x60;&#x60;json {   \&quot;next\&quot;: null,   \&quot;previous\&quot;: null,   \&quot;results\&quot;: [     {       \&quot;completed_at\&quot;: \&quot;2023-09-08T16:41:19.826523Z\&quot;,       \&quot;created_at\&quot;: \&quot;2023-09-08T16:32:57.018467Z\&quot;,       \&quot;error\&quot;: null,       \&quot;id\&quot;: \&quot;zz4ibbonubfz7carwiefibzgga\&quot;,       \&quot;input\&quot;: {         \&quot;input_images\&quot;: \&quot;https://example.com/my-input-images.zip\&quot;       },       \&quot;metrics\&quot;: {         \&quot;predict_time\&quot;: 502.713876       },       \&quot;output\&quot;: {         \&quot;version\&quot;: \&quot;...\&quot;,         \&quot;weights\&quot;: \&quot;...\&quot;       },       \&quot;started_at\&quot;: \&quot;2023-09-08T16:32:57.112647Z\&quot;,       \&quot;source\&quot;: \&quot;api\&quot;,       \&quot;status\&quot;: \&quot;succeeded\&quot;,       \&quot;urls\&quot;: {         \&quot;get\&quot;: \&quot;https://api.replicate.com/v1/trainings/zz4ibbonubfz7carwiefibzgga\&quot;,         \&quot;cancel\&quot;: \&quot;https://api.replicate.com/v1/trainings/zz4ibbonubfz7carwiefibzgga/cancel\&quot;       },       \&quot;model\&quot;: \&quot;stability-ai/sdxl\&quot;,       \&quot;version\&quot;: \&quot;da77bc59ee60423279fd632efb4795ab731d9e3ca9705ef3341091fb989b7eaf\&quot;,     }   ] } &#x60;&#x60;&#x60;  &#x60;id&#x60; will be the unique ID of the training.  &#x60;source&#x60; will indicate how the training was created. Possible values are &#x60;web&#x60; or &#x60;api&#x60;.  &#x60;status&#x60; will be the status of the training. Refer to [get a single training](#trainings.get) for possible values.  &#x60;urls&#x60; will be a convenience object that can be used to construct new API requests for the given training.  &#x60;version&#x60; will be the unique ID of model version used to create the training. 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void TrainingsList(int operationIndex = 0)
        {
            TrainingsListWithHttpInfo();
        }

        /// <summary>
        /// List trainings Get a paginated list of trainings that you&#39;ve created. This will include trainings created from the API and the website. It will return 100 records per page.  Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/trainings &#x60;&#x60;&#x60;  The response will be a paginated JSON array of training objects, sorted with the most recent training first:  &#x60;&#x60;&#x60;json {   \&quot;next\&quot;: null,   \&quot;previous\&quot;: null,   \&quot;results\&quot;: [     {       \&quot;completed_at\&quot;: \&quot;2023-09-08T16:41:19.826523Z\&quot;,       \&quot;created_at\&quot;: \&quot;2023-09-08T16:32:57.018467Z\&quot;,       \&quot;error\&quot;: null,       \&quot;id\&quot;: \&quot;zz4ibbonubfz7carwiefibzgga\&quot;,       \&quot;input\&quot;: {         \&quot;input_images\&quot;: \&quot;https://example.com/my-input-images.zip\&quot;       },       \&quot;metrics\&quot;: {         \&quot;predict_time\&quot;: 502.713876       },       \&quot;output\&quot;: {         \&quot;version\&quot;: \&quot;...\&quot;,         \&quot;weights\&quot;: \&quot;...\&quot;       },       \&quot;started_at\&quot;: \&quot;2023-09-08T16:32:57.112647Z\&quot;,       \&quot;source\&quot;: \&quot;api\&quot;,       \&quot;status\&quot;: \&quot;succeeded\&quot;,       \&quot;urls\&quot;: {         \&quot;get\&quot;: \&quot;https://api.replicate.com/v1/trainings/zz4ibbonubfz7carwiefibzgga\&quot;,         \&quot;cancel\&quot;: \&quot;https://api.replicate.com/v1/trainings/zz4ibbonubfz7carwiefibzgga/cancel\&quot;       },       \&quot;model\&quot;: \&quot;stability-ai/sdxl\&quot;,       \&quot;version\&quot;: \&quot;da77bc59ee60423279fd632efb4795ab731d9e3ca9705ef3341091fb989b7eaf\&quot;,     }   ] } &#x60;&#x60;&#x60;  &#x60;id&#x60; will be the unique ID of the training.  &#x60;source&#x60; will indicate how the training was created. Possible values are &#x60;web&#x60; or &#x60;api&#x60;.  &#x60;status&#x60; will be the status of the training. Refer to [get a single training](#trainings.get) for possible values.  &#x60;urls&#x60; will be a convenience object that can be used to construct new API requests for the given training.  &#x60;version&#x60; will be the unique ID of model version used to create the training. 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public dotnetReplicate.Client.ApiResponse<Object> TrainingsListWithHttpInfo(int operationIndex = 0)
        {
            dotnetReplicate.Client.RequestOptions localVarRequestOptions = new dotnetReplicate.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };

            var localVarContentType = dotnetReplicate.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = dotnetReplicate.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }


            localVarRequestOptions.Operation = "DefaultApi.TrainingsList";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Get<Object>("/trainings", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("TrainingsList", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// List trainings Get a paginated list of trainings that you&#39;ve created. This will include trainings created from the API and the website. It will return 100 records per page.  Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/trainings &#x60;&#x60;&#x60;  The response will be a paginated JSON array of training objects, sorted with the most recent training first:  &#x60;&#x60;&#x60;json {   \&quot;next\&quot;: null,   \&quot;previous\&quot;: null,   \&quot;results\&quot;: [     {       \&quot;completed_at\&quot;: \&quot;2023-09-08T16:41:19.826523Z\&quot;,       \&quot;created_at\&quot;: \&quot;2023-09-08T16:32:57.018467Z\&quot;,       \&quot;error\&quot;: null,       \&quot;id\&quot;: \&quot;zz4ibbonubfz7carwiefibzgga\&quot;,       \&quot;input\&quot;: {         \&quot;input_images\&quot;: \&quot;https://example.com/my-input-images.zip\&quot;       },       \&quot;metrics\&quot;: {         \&quot;predict_time\&quot;: 502.713876       },       \&quot;output\&quot;: {         \&quot;version\&quot;: \&quot;...\&quot;,         \&quot;weights\&quot;: \&quot;...\&quot;       },       \&quot;started_at\&quot;: \&quot;2023-09-08T16:32:57.112647Z\&quot;,       \&quot;source\&quot;: \&quot;api\&quot;,       \&quot;status\&quot;: \&quot;succeeded\&quot;,       \&quot;urls\&quot;: {         \&quot;get\&quot;: \&quot;https://api.replicate.com/v1/trainings/zz4ibbonubfz7carwiefibzgga\&quot;,         \&quot;cancel\&quot;: \&quot;https://api.replicate.com/v1/trainings/zz4ibbonubfz7carwiefibzgga/cancel\&quot;       },       \&quot;model\&quot;: \&quot;stability-ai/sdxl\&quot;,       \&quot;version\&quot;: \&quot;da77bc59ee60423279fd632efb4795ab731d9e3ca9705ef3341091fb989b7eaf\&quot;,     }   ] } &#x60;&#x60;&#x60;  &#x60;id&#x60; will be the unique ID of the training.  &#x60;source&#x60; will indicate how the training was created. Possible values are &#x60;web&#x60; or &#x60;api&#x60;.  &#x60;status&#x60; will be the status of the training. Refer to [get a single training](#trainings.get) for possible values.  &#x60;urls&#x60; will be a convenience object that can be used to construct new API requests for the given training.  &#x60;version&#x60; will be the unique ID of model version used to create the training. 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task TrainingsListAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await TrainingsListWithHttpInfoAsync(operationIndex, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// List trainings Get a paginated list of trainings that you&#39;ve created. This will include trainings created from the API and the website. It will return 100 records per page.  Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/trainings &#x60;&#x60;&#x60;  The response will be a paginated JSON array of training objects, sorted with the most recent training first:  &#x60;&#x60;&#x60;json {   \&quot;next\&quot;: null,   \&quot;previous\&quot;: null,   \&quot;results\&quot;: [     {       \&quot;completed_at\&quot;: \&quot;2023-09-08T16:41:19.826523Z\&quot;,       \&quot;created_at\&quot;: \&quot;2023-09-08T16:32:57.018467Z\&quot;,       \&quot;error\&quot;: null,       \&quot;id\&quot;: \&quot;zz4ibbonubfz7carwiefibzgga\&quot;,       \&quot;input\&quot;: {         \&quot;input_images\&quot;: \&quot;https://example.com/my-input-images.zip\&quot;       },       \&quot;metrics\&quot;: {         \&quot;predict_time\&quot;: 502.713876       },       \&quot;output\&quot;: {         \&quot;version\&quot;: \&quot;...\&quot;,         \&quot;weights\&quot;: \&quot;...\&quot;       },       \&quot;started_at\&quot;: \&quot;2023-09-08T16:32:57.112647Z\&quot;,       \&quot;source\&quot;: \&quot;api\&quot;,       \&quot;status\&quot;: \&quot;succeeded\&quot;,       \&quot;urls\&quot;: {         \&quot;get\&quot;: \&quot;https://api.replicate.com/v1/trainings/zz4ibbonubfz7carwiefibzgga\&quot;,         \&quot;cancel\&quot;: \&quot;https://api.replicate.com/v1/trainings/zz4ibbonubfz7carwiefibzgga/cancel\&quot;       },       \&quot;model\&quot;: \&quot;stability-ai/sdxl\&quot;,       \&quot;version\&quot;: \&quot;da77bc59ee60423279fd632efb4795ab731d9e3ca9705ef3341091fb989b7eaf\&quot;,     }   ] } &#x60;&#x60;&#x60;  &#x60;id&#x60; will be the unique ID of the training.  &#x60;source&#x60; will indicate how the training was created. Possible values are &#x60;web&#x60; or &#x60;api&#x60;.  &#x60;status&#x60; will be the status of the training. Refer to [get a single training](#trainings.get) for possible values.  &#x60;urls&#x60; will be a convenience object that can be used to construct new API requests for the given training.  &#x60;version&#x60; will be the unique ID of model version used to create the training. 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<dotnetReplicate.Client.ApiResponse<Object>> TrainingsListWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            dotnetReplicate.Client.RequestOptions localVarRequestOptions = new dotnetReplicate.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };

            var localVarContentType = dotnetReplicate.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = dotnetReplicate.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }


            localVarRequestOptions.Operation = "DefaultApi.TrainingsList";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<Object>("/trainings", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("TrainingsList", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the signing secret for the default webhook Get the signing secret for the default webhook endpoint. This is used to verify that webhook requests are coming from Replicate.  Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/webhooks/default/secret &#x60;&#x60;&#x60;  The response will be a JSON object with a &#x60;key&#x60; property:  &#x60;&#x60;&#x60;json {   \&quot;key\&quot;: \&quot;...\&quot; } &#x60;&#x60;&#x60; 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>WebhooksDefaultSecretGet200Response</returns>
        public WebhookResponse WebhooksDefaultSecretGet(int operationIndex = 0)
        {
            dotnetReplicate.Client.ApiResponse<WebhookResponse> localVarResponse = WebhooksDefaultSecretGetWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the signing secret for the default webhook Get the signing secret for the default webhook endpoint. This is used to verify that webhook requests are coming from Replicate.  Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/webhooks/default/secret &#x60;&#x60;&#x60;  The response will be a JSON object with a &#x60;key&#x60; property:  &#x60;&#x60;&#x60;json {   \&quot;key\&quot;: \&quot;...\&quot; } &#x60;&#x60;&#x60; 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of WebhooksDefaultSecretGet200Response</returns>
        public dotnetReplicate.Client.ApiResponse<WebhookResponse> WebhooksDefaultSecretGetWithHttpInfo(int operationIndex = 0)
        {
            dotnetReplicate.Client.RequestOptions localVarRequestOptions = new dotnetReplicate.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = dotnetReplicate.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = dotnetReplicate.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }


            localVarRequestOptions.Operation = "DefaultApi.WebhooksDefaultSecretGet";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Get<WebhookResponse>("/webhooks/default/secret", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("WebhooksDefaultSecretGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the signing secret for the default webhook Get the signing secret for the default webhook endpoint. This is used to verify that webhook requests are coming from Replicate.  Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/webhooks/default/secret &#x60;&#x60;&#x60;  The response will be a JSON object with a &#x60;key&#x60; property:  &#x60;&#x60;&#x60;json {   \&quot;key\&quot;: \&quot;...\&quot; } &#x60;&#x60;&#x60; 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of WebhooksDefaultSecretGet200Response</returns>
        public async System.Threading.Tasks.Task<WebhookResponse> WebhooksDefaultSecretGetAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            dotnetReplicate.Client.ApiResponse<WebhookResponse> localVarResponse = await WebhooksDefaultSecretGetWithHttpInfoAsync(operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the signing secret for the default webhook Get the signing secret for the default webhook endpoint. This is used to verify that webhook requests are coming from Replicate.  Example cURL request:  &#x60;&#x60;&#x60;console curl -s \\   -H \&quot;Authorization: Token &lt;paste-your-token-here&gt;\&quot; \\   https://api.replicate.com/v1/webhooks/default/secret &#x60;&#x60;&#x60;  The response will be a JSON object with a &#x60;key&#x60; property:  &#x60;&#x60;&#x60;json {   \&quot;key\&quot;: \&quot;...\&quot; } &#x60;&#x60;&#x60; 
        /// </summary>
        /// <exception cref="dotnetReplicate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (WebhooksDefaultSecretGet200Response)</returns>
        public async System.Threading.Tasks.Task<dotnetReplicate.Client.ApiResponse<WebhookResponse>> WebhooksDefaultSecretGetWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            dotnetReplicate.Client.RequestOptions localVarRequestOptions = new dotnetReplicate.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = dotnetReplicate.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = dotnetReplicate.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }


            localVarRequestOptions.Operation = "DefaultApi.WebhooksDefaultSecretGet";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<WebhookResponse>("/webhooks/default/secret", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("WebhooksDefaultSecretGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
