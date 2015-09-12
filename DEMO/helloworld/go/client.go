package HelloWorld

// Code generated by Microsoft (R) AutoRest Code Generator 0.11.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

import (
    "github.com/Azure/go-autorest/autorest"
    "net/http"
)

const (
    ApiVersion = "1.0.0"
    DefaultBaseUri = "http://localhost:9990"
)

type MyClient struct {
    autorest.Client
    BaseUri string
    SubscriptionId string
}

func New(subscriptionId string) MyClient {
    return NewWithBaseUri(DefaultBaseUri, subscriptionId)
}

func NewWithBaseUri(baseUri string, subscriptionId string) MyClient {
    return MyClient{
        Client: autorest.DefaultClient,
        BaseUri: baseUri,
        SubscriptionId: subscriptionId,
    }
}

// GetGreeting
func (client MyClient) GetGreeting() (result string, ae autorest.Error) {
    req, err := client.NewGetGreetingRequest()
    if err != nil {
        return result, autorest.NewErrorWithError(err, "HelloWorld.MyClient", "GetGreeting", "Failure creating request")
    }

    req, err = autorest.Prepare(
        req,
        client.WithAuthorization(),
        client.WithInspection())
    if err != nil {
        return result, autorest.NewErrorWithError(err, "HelloWorld.MyClient", "GetGreeting", "Failure preparing request")
    }

    resp, err := autorest.SendWithSender(
        client,
        req,
        autorest.DoErrorUnlessStatusCode(http.StatusOK))

    if err == nil {
        err = autorest.Respond(
            resp,
            client.ByInspecting(),
            autorest.WithErrorUnlessOK(),
            autorest.ByUnmarshallingJSON(&result))
        if err != nil {
            ae = autorest.NewErrorWithError(err, "HelloWorld.MyClient", "GetGreeting", "Failure responding to request")
        }
    } else {
        ae = autorest.NewErrorWithError(err, "HelloWorld.MyClient", "GetGreeting", "Failure sending request")
    }

    autorest.Respond(resp,
        autorest.ByClosing())
    result.Response = autorest.Response{Response: resp}

    return
}

// Create the GetGreeting request.
func (client MyClient) NewGetGreetingRequest() (*http.Request, error) {
    return autorest.DecoratePreparer(
        client.GetGreetingRequestPreparer()).Prepare(&http.Request{})
}

// Create a Preparer by which to prepare the GetGreeting request.
func (client MyClient) GetGreetingRequestPreparer() autorest.Preparer {
    return autorest.CreatePreparer(
        autorest.AsJSON(),
        autorest.AsGet(),
        autorest.WithBaseURL(client.BaseUri),
        autorest.WithPath("/api/HelloWorld"))
}
