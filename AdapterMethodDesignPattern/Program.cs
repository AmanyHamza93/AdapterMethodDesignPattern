using AdapterMethodDesignPattern;

NewService newService = new NewService();
IlegacyService adapter = new Adapter(newService);
adapter.LegacyRequest();