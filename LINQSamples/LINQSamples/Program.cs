using LINQSamples;

// Create instance of view model
SamplesViewModel vm = new();

// Call Sample Method
var result = vm.FirstOrDefaultQuery();

// Display Results
vm.Display(result);