/**
 * Code generated by Microsoft (R) AutoRest Code Generator 0.11.0.0
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

package helloworld;

import com.microsoft.rest.ServiceClient;
import com.squareup.okhttp.OkHttpClient;
import retrofit.RestAdapter;
import com.google.gson.reflect.TypeToken;
import com.microsoft.rest.ServiceCallback;
import com.microsoft.rest.ServiceException;
import com.microsoft.rest.ServiceResponse;
import com.microsoft.rest.ServiceResponseBuilder;
import com.microsoft.rest.ServiceResponseCallback;
import retrofit.RetrofitError;
import retrofit.client.Response;

/**
 * Initializes a new instance of the MyClient class.
 */
public class MyClientImpl extends ServiceClient implements MyClient {
    private MyClientService service;
    private String baseUri;

    /**
     * Gets the URI used as the base for all cloud service requests.
     * @return The BaseUri value.
     */
    public String getBaseUri() {
        return this.baseUri;
    }

    /**
     * Initializes an instance of MyClient client.
     */
    public MyClientImpl() {
        this("http://localhost:9990");
    }

    /**
     * Initializes an instance of MyClient client.
     *
     * @param baseUri the base URI of the host
     */
    public MyClientImpl(String baseUri) {
        super();
        this.baseUri = baseUri;
        initialize();
    }

    /**
     * Initializes an instance of MyClient client.
     *
     * @param baseUri the base URI of the host
     * @param client the {@link OkHttpClient} client to use for REST calls
     * @param restAdapterBuilder the builder for building up a {@link RestAdapter}
     */
    public MyClientImpl(String baseUri, OkHttpClient client, RestAdapter.Builder restAdapterBuilder) {
        super(client, restAdapterBuilder);
        this.baseUri = baseUri;
        initialize();
    }

    private void initialize() {
        RestAdapter restAdapter = restAdapterBuilder.setEndpoint(baseUri).build();
        service = restAdapter.create(MyClientService.class);
    }

    /**
     *
     * @return the String object if successful.
     * @throws ServiceException the exception wrapped in ServiceException if failed.
     */
    public String getGreeting() throws ServiceException {
        try {
            ServiceResponse<String> response = getGreetingDelegate(service.getGreeting(), null);
            return response.getBody();
        } catch (RetrofitError error) {
            ServiceResponse<String> response = getGreetingDelegate(error.getResponse(), error);
            return response.getBody();
        }
    }

    /**
     *
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     */
    public void getGreetingAsync(final ServiceCallback<String> serviceCallback) {
        service.getGreetingAsync(new ServiceResponseCallback() {
            @Override
            public void response(Response response, RetrofitError error) {
                try {
                    serviceCallback.success(getGreetingDelegate(response, error));
                } catch (ServiceException exception) {
                    serviceCallback.failure(exception);
                }
            }
        });
    }

    private ServiceResponse<String> getGreetingDelegate(Response response, RetrofitError error) throws ServiceException {
        return new ServiceResponseBuilder<String>()
                .register(200, new TypeToken<String>(){}.getType())
                .build(response, error);
    }

}