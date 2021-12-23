# DependancyInjectionExperiment

Small project to practice with while learning to use Dependancy Injection with multiple winforms in an app

## Form1
Loads Form1 into the panel on MainForm. Dependancies are injected into the ctor of the form.

## Form2
Loads Form2 into the panel on MainForm. Dependancies are injected into the ctor of the form.
Required parameters (values not known when the form is added to the DI system) are passed in using a public method.

## Form2a
As above but this time forgetting to pass in the required parameters.

## Form3
Instead of Form3 being in the DI system the forms dependancies are passed into the ctor as parameters.  

Feels a bit more winformy to me!

## Form4
As Form3 but uses a factory class as described here. https://stackoverflow.com/questions/66712977/net-5-windows-forms-with-dependency-injection-how-to-pass-form-properties-fro  
Don't see the benefit of this over the form3 method.
