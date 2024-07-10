import Contract.interface
import CloudLogger

# class program: Contract.interface.Iloggerlass FileLogger(Contract.interface.Ilogger):
    def write_log(self, message):
        print(f"File Logger: {message}")
        


def __init__():
    log = "File"
    
    if log == "File":
        return FileLogger()
    else:
        return CloudLogger()

class LogManager:
    def __init__(self, logger):
        self.logger = logger

    def write_log(self, message):
        self.logger.write_log(message)

if __name__ == "__main__":
    log = __init__()
    
    log_manager = LogManager(log)
    
    log_manager.write_log("Finally Ho gya Kya?")



    