# Messages

- contains raw data
  - no references to data
  - consumed by another component
- sending component expects the receiver to do something with the message
- the systems integrity depends on the delivery of the message

## Message Queue

- increase reliability
  - receiver has nt to be present, when sending
- **delivery guarentees**:
  - At-Least-Once Delivery:
    - at least on message gets delivered
    - possiblity, when message times out, but got processed, that this messages gets delivered again
  - At-Most-Once Delivery:
    - only one message gets delivered, no matter there was a timeout or not
- most in FIFO
- transaction support    


- Azure Queue Storage
  - stored in Azure Storage
- Azure Service Bus
  - enterprise features
  - **topics**:
    - like separated queues 
    - but subscribed by multiply components


- **Use Service Bus topics if you:**
  - Need multiple receivers to handle each message
  - Use Service Bus queues if you:
  - Need an At-Most-Once delivery guarantee.
  - Need a FIFO guarantee.
  - Need to group messages into transactions.
  - Want to receive messages without polling the queue.
  - Need to provide a role-based access model to the queues.
  - Need to handle messages larger than 64 KB but less than 256 KB.
  - Queue size will not grow larger than 80 GB.
  - Want to publish and consume batches of messages.

- **Use Queue storage if you:**:
  - Need an audit trail of all messages that pass through the queue.
  - Expect the queue to exceed 80 GB in size.
  - Want to track progress for processing a message inside of the queue.