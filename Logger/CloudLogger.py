import Contract.interface

class CloudLogger(Contract.interface.Ilogger):
    def write_log(self, message):
        print(f"Cloud Logger: {message}")
