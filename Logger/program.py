import Contract.interface
import CloudLogger


    def write_log(self, message):
        print(f"File Logger: {message}")
        


def getlog():
    log = "File"
    
    if log == "File":
        return FileLogger()
    else:
        return CloudLogger()

class LogManager:
    def getlog(self, logger):
        self.logger = logger

    def write_log(self, message):
        self.logger.write_log(message)

if __name__ == "__main__":
    log = getlog()
    
    log_manager = LogManager(log)
    
    log_manager.write_log("Finally Ho gya Kya?")



    
