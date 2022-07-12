// Script which can be run after HTTP requests
client.test("Successful request with OK 204", () => {
    client.assert(response.status === 204, "HTTP Response status code is not 204");
});
