## Batch Service Library

The Batch Service Library is written to turn a .NET Core Workder Service 
into a batch processing service.  Normally, the worker service will run in
a host until outside quit signal is received, such as the user pressing
Ctrl-C.  When using the Batch Service Library, a batch job can be registered
such that the batch can signal back to the host that processing is complete
and that it should shut down.

There are contructs to:

* Define the batch job name via an attribute.
* Create the dedicated worker class and associate with the runnable host.
* Create and define job steps via a builder object.
* Define input, output, and process operation for each job step.


Note that as of right now (12/20) this is VERY EARLY prelimanary work.
The mechanism for registring the batch job and stopping it has been 
defined, but the input, output, and processing classes have yet to be 
defined.