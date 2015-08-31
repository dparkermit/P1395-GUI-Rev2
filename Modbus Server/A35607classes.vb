Enum MODBUS_COMMANDS
    MODBUS_WR_HVLAMBDA = 1
    MODBUS_WR_ION_PUMP
    MODBUS_WR_AFC
    MODBUS_WR_COOLING
    MODBUS_WR_HTR_MAGNET
    MODBUS_WR_GUN_DRIVER
    MODBUS_WR_MAGNETRON_CURRENT
    MODBUS_WR_PULSE_SYNC
    MODBUS_WR_ETHERNET
    MODBUS_WR_DEBUG_DATA
    MODBUS_WR_EVENTS

    MODBUS_WR_ONE_CAL_ENTRY
    MODBUS_WR_PULSE_LOG
    MODBUS_RD_COMMAND_DETAIL

End Enum

Enum CS_ETHER
    CONTROL_STATE
    SYSTEM_POWERED_SECONDS_W1
    SYSTEM_POWERED_SECONDS_W2
    SYSTEM_HV_ON_SECONDS_W1
    SYSTEM_HV_ON_SECONDS_W2
    SYSTEM_XRAY_ON_SECONDS_W1
    SYSTEM_XRAY_ON_SECONDS_W2
    TIME_SECONDS_NOW_W1
    TIME_SECONDS_NOW_W2
    AVERAGE_OUTPUT_POWER_WATTS
    THYRATRON_WARMUP_COUNTER_SECONDS
    MAGNETRON_HEATER_WARMUP_COUNTER_SECONDS
    GUN_DRIVER_HEATER_WARMUP_COUNTER_SECONDS
    SYNC_0_CONTROL_WORD
    BOARD_COM_FAULT
End Enum

Enum CS_HVLAMBDA
	  ECB_HIGH_SET_POINT
	  ECB_LOW_SET_POINT

	  EOC_NOT_REACHED_COUNT
	  READBACK_VMON
	  READBACK_IMON
	  READBACK_BASE_PLATE_TEMP

	  READBACK_HIGH_VPROG
	  READBACK_LOW_VPROG
	  READBACK_PEAK_LAMBDA_VOLTAGE
End Enum

Enum CS_IONPUMP
	  ION_PUMP_VOLAGE_MONITOR
	  ION_PUMP_CURRENT_MONITOR
	  FILTERED_HIGH_ENERGY_TARGET_CURRENT
	  FILTERED_LOW_ENERGY_TARGET_CURRENT
End Enum

Enum CS_AFC
  HOME_POSITION
  OFFSET
  
  READBACK_HOME_POSITION
  READBACK_OFFSET
  READBACK_CURRENT_POSITION

  READBACK_AFC_A_INPUT_READING
  READBACK_AFC_B_INPUT_READING
  READBACK_FILTERED_ERROR_READING
  READBACK_TARGET_POSITION
  
  AFT_CONTROL_VOLTAGE
  READBACK_AFT_CONTROL_VOLTAGE
End Enum

Enum CS_COOLING
	  HVPS_COOLANT_FLOW
	  MAGNETRON_COOLANT_FLOW
	  LINAC_COOLANT_FLOW
	  CIRCULATOR_COOLANT_FLOW
	  HX_COOLANT_FLOW
	  SPARE_COOLANT_FLOW
	  COOLANT_TEMPERATURE
	  SF6_PRESSURE
	  CABINET_TEMPERATURE
	  LINAC_TEMPERATURE
    BOTTLE_COUNT
    PULSES_AVAILABLE
    LOW_PRESSURE_OVERRIDE_AVAILABLE
End Enum

Enum CS_HTRMAG
	 MAGNET_CURRENT_SET_POINT
	 HEATER_CURRENT_SET_POINT
	 
	 READBACK_HEATER_CURRENT
	 READBACK_HEATER_VOLTAGE
	 READBACK_MAGNET_CURRENT
	 READBACK_MAGNET_VOLTAGE
	 READBACK_HEATER_CURRENT_SET_POINT
	 READBACK_HEATER_VOLTAGE_SET_POINT
	 READBACK_MAGNET_CURRENT_SET_POINT
	 READBACK_MAGNET_VOLTAGE_SET_POINT

	 HEATER_CURRENT_SET_POINT_SCALED
	 HTRMAG_HEATER_ENABLE
End Enum

Enum CS_GD
	  HIGH_ENERGY_PULSE_TOP_VOLTAGE_SET_POINT
	  LOW_ENERGY_PULSE_TOP_VOLTAGE_SET_POINT
	  HEATER_VOLTAGE_SET_POINT
	  CATHODE_VOLTAGE_SET_POINT
	  
	  READBACK_HIGH_ENERGY_PULSE_TOP_VOLTAGE_MONITOR
	  READBACK_LOW_ENERGY_PULSE_TOP_VOLTAGE_MONITOR
	  READBACK_CATHODE_VOLTAGE_MONITOR
	  READBACK_PEAK_BEAM_CURRENT
	  READBACK_HEATER_VOLTAGE_MONITOR
	  READBACK_HEATER_CURRENT_MONITOR
	  READBACK_HEATER_TIME_DELAY_REMAINING
	  READBACK_DRIVER_TEMPERATURE
	  READBACK_HIGH_ENERGY_PULSE_TOP_SET_POINT
	  READBACK_LOW_ENERGY_PULSE_TOP_SET_POINT
	  READBACK_HEATER_VOLTAGE_SET_POINT
	  READBACK_CATHODE_VOLTAGE_SET_POINT

	  READBACK_FPGA_ASDR_REGISTER
	  READBACK_ANALOG_FAULT_STATUS
	  READBACK_SYSTEM_LOGIC_STATE
	  READBACK_BIAS_VOLTAGE_MON

End Enum

Enum CS_MAGNETRON
	  READBACK_SPARE
	  READBACK_ARCS_THIS_HV_ON
	  FILTERED_HIGH_ENERGY_PULSE_CURRENT
	  FILTERED_LOW_ENERGY_PULSE_CURRENT
	  ARCS_LIFETIME_W1
	  ARCS_LIFETIME_W2
	  PULSES_THIS_HV_ON_W1
	  PULSES_THIS_HV_ON_W2
	  PULSES_LIFETIME_W1
	  PULSES_LIFETIME_W2
	  PULSES_LIFETIME_W3
	  PULSES_LIFETIME_W4
End Enum

Enum CS_PULSESYNC
	  GRID_DELAY_HIGH_INTENSITY_32
	  GRID_DELAY_HIGH_INTENSITY_10
	  PFN_DELAY_HIGH_AND_DOSE_SAMPLE_DELAY_HIGH

	  GRID_WIDTH_HIGH_INTENSITY_32
	  GRID_WIDTH_HIGH_INTENSITY_10
	  AFC_DELAY_HIGH_AND_MAGNETRON_CURRENT_SAMPLE_DELAY_HIGH

	  GRID_DELAY_LOW_INTENSITY_32
	  GRID_DELAY_LOW_INTENSITY_10
	  PFN_DELAY_LOW_AND_DOSE_SAMPLE_DELAY_LOW
	 
	  GRID_WIDTH_LOW_INTENSITY_32
	  GRID_WIDTH_LOW_INTENSITY_10
	  AFC_DELAY_LOW_AND_MAGNETRON_CURRENT_SAMPLE_DELAY_LOW

      CUSTOMER_LED
End Enum




Public Class ETM_CAN_STATUS_REGISTER
    Public status_word_0 As UInt16
    Public status_word_1 As UInt16
    Public data_word_A As UInt16
    Public data_word_B As UInt16

    Public status_word_0_inhbit_mask As UInt16
    Public status_word_1_fault_mask As UInt16

    Public Sub SetData(ByRef data As Byte(), ByVal length As UInt16, ByVal offset As Byte)
        If (length < 12) Then Exit Sub
        status_word_0 = (CUShort(data(offset + 1)) << 8) + CUShort(data(offset))
        status_word_1 = (CUShort(data(offset + 3)) << 8) + CUShort(data(offset + 2))
        data_word_A = (CUShort(data(offset + 5)) << 8) + CUShort(data(offset + 4))
        data_word_B = (CUShort(data(offset + 7)) << 8) + CUShort(data(offset + 6))

        status_word_0_inhbit_mask = (CUShort(data(offset + 9)) << 8) + CUShort(data(offset + 8))
        status_word_1_fault_mask = (CUShort(data(offset + 11)) << 8) + CUShort(data(offset + 10))
    End Sub
End Class

Public Class ETM_CAN_SYSTEM_DEBUG_DATA
    Public i2c_bus_error_count As UInt16
    Public spi_bus_error_count As UInt16
    Public can_bus_error_count As UInt16
    Public scale_error_count As UInt16

    Public reset_count As UInt16
    Public self_test_result_register As UInt16
    Public reserved_0 As UInt16
    Public reserved_1 As UInt16

    Public debug_0 As UInt16
    Public debug_1 As UInt16
    Public debug_2 As UInt16
    Public debug_3 As UInt16

    Public debug_4 As UInt16
    Public debug_5 As UInt16
    Public debug_6 As UInt16
    Public debug_7 As UInt16

    Public debug_8 As UInt16
    Public debug_9 As UInt16
    Public debug_A As UInt16
    Public debug_B As UInt16

    Public debug_C As UInt16
    Public debug_D As UInt16
    Public debug_E As UInt16
    Public debug_F As UInt16

    Public Sub SetData(ByRef data As Byte(), ByVal length As UInt16, ByVal offset As Byte)
        Dim i As Byte
        If (length < 48) Then Exit Sub

        i = offset
        i2c_bus_error_count = (CUShort(data(i + 1)) << 8) + CUShort(data(i))
        spi_bus_error_count = (CUShort(data(i + 3)) << 8) + CUShort(data(i + 2))
        can_bus_error_count = (CUShort(data(i + 5)) << 8) + CUShort(data(i + 4))
        scale_error_count = (CUShort(data(i + 7)) << 8) + CUShort(data(i + 6))

        i = i + 8
        reset_count = (CUShort(data(i + 1)) << 8) + CUShort(data(i))
        self_test_result_register = (CUShort(data(i + 3)) << 8) + CUShort(data(i + 2))
        reserved_0 = (CUShort(data(i + 5)) << 8) + CUShort(data(i + 4))
        reserved_1 = (CUShort(data(i + 7)) << 8) + CUShort(data(i + 6))

        i = i + 8
        debug_0 = (CUShort(data(i + 1)) << 8) + CUShort(data(i))
        debug_1 = (CUShort(data(i + 3)) << 8) + CUShort(data(i + 2))
        debug_2 = (CUShort(data(i + 5)) << 8) + CUShort(data(i + 4))
        debug_3 = (CUShort(data(i + 7)) << 8) + CUShort(data(i + 6))

        i = i + 8 '24
        debug_4 = (CUShort(data(i + 1)) << 8) + CUShort(data(i))
        debug_5 = (CUShort(data(i + 3)) << 8) + CUShort(data(i + 2))
        debug_6 = (CUShort(data(i + 5)) << 8) + CUShort(data(i + 4))
        debug_7 = (CUShort(data(i + 7)) << 8) + CUShort(data(i + 6))

        i = i + 8 '32
        debug_8 = (CUShort(data(i + 1)) << 8) + CUShort(data(i))
        debug_9 = (CUShort(data(i + 3)) << 8) + CUShort(data(i + 2))
        debug_A = (CUShort(data(i + 5)) << 8) + CUShort(data(i + 4))
        debug_B = (CUShort(data(i + 7)) << 8) + CUShort(data(i + 6))

        i = i + 8 '40
        debug_C = (CUShort(data(i + 1)) << 8) + CUShort(data(i))
        debug_D = (CUShort(data(i + 3)) << 8) + CUShort(data(i + 2))
        debug_E = (CUShort(data(i + 5)) << 8) + CUShort(data(i + 4))
        debug_F = (CUShort(data(i + 7)) << 8) + CUShort(data(i + 6))


    End Sub
End Class






Public Class ETM_CAN_CAN_STATUS
    ' Can data log 0
    Public can_status_CXEC_reg As UInt16
    Public can_status_error_flag As UInt16
    Public can_status_tx_1 As UInt16
    Public can_status_tx_2 As UInt16

    ' Can data log 1
    Public can_status_rx_0_filt_0 As UInt16
    Public can_status_rx_0_filt_1 As UInt16
    Public can_status_rx_1_filt_2 As UInt16
    Public can_status_isr_entered As UInt16

    ' Can data log 2
    Public can_status_unknown_message_identifier As UInt16
    Public can_status_invalid_index As UInt16
    Public can_status_address_error As UInt16
    Public can_status_tx_0 As UInt16

    ' Can data log 3
    Public can_status_message_tx_buffer_overflow As UInt16
    Public can_status_message_rx_buffer_overflow As UInt16
    Public can_status_data_log_rx_buffer_overflow As UInt16
    Public can_status_timeout As UInt16

    Public Sub SetData(ByRef data As Byte(), ByVal length As UInt16, ByVal offset As Byte)
        Dim i As Byte
        If (length < 32) Then Exit Sub

        i = offset
        can_status_CXEC_reg = (CUShort(data(i + 1)) << 8) + CUShort(data(i))
        can_status_error_flag = (CUShort(data(i + 3)) << 8) + CUShort(data(i + 2))
        can_status_tx_1 = (CUShort(data(i + 5)) << 8) + CUShort(data(i + 4))
        can_status_tx_2 = (CUShort(data(i + 7)) << 8) + CUShort(data(i + 6))

        i = i + 8 '8
        can_status_rx_0_filt_0 = (CUShort(data(i + 1)) << 8) + CUShort(data(i))
        can_status_rx_0_filt_1 = (CUShort(data(i + 3)) << 8) + CUShort(data(i + 2))
        can_status_rx_1_filt_2 = (CUShort(data(i + 5)) << 8) + CUShort(data(i + 4))
        can_status_isr_entered = (CUShort(data(i + 7)) << 8) + CUShort(data(i + 6))

        i = i + 8 '16
        can_status_unknown_message_identifier = (CUShort(data(i + 1)) << 8) + CUShort(data(i))
        can_status_invalid_index = (CUShort(data(i + 3)) << 8) + CUShort(data(i + 2))
        can_status_address_error = (CUShort(data(i + 5)) << 8) + CUShort(data(i + 4))
        can_status_tx_0 = (CUShort(data(i + 7)) << 8) + CUShort(data(i + 6))

        i = i + 8 '24
        can_status_message_tx_buffer_overflow = (CUShort(data(i + 1)) << 8) + CUShort(data(i))
        can_status_message_rx_buffer_overflow = (CUShort(data(i + 3)) << 8) + CUShort(data(i + 2))
        can_status_data_log_rx_buffer_overflow = (CUShort(data(i + 5)) << 8) + CUShort(data(i + 4))
        can_status_timeout = (CUShort(data(i + 7)) << 8) + CUShort(data(i + 6))



    End Sub
End Class

Public Class ETM_CAN_AGILE_CONFIG
    ' Configuration 0
    Public agile_number_high_word As UInt16
    Public agile_number_low_word As UInt16
    Public agile_dash As UInt16
    Public agile_rev_ascii As UInt16

    ' Configuarion 1
    Public serial_number As UInt16
    Public firmware_branch As UInt16
    Public firmware_major_rev As UInt16
    Public firmware_minor_rev As UInt16

    Public Sub SetData(ByRef data As Byte(), ByVal length As UInt16, ByVal offset As Byte)
        Dim i As Byte
        If (length < 16) Then Exit Sub

        i = offset
        agile_number_high_word = (CUShort(data(i + 1)) << 8) + CUShort(data(i))
        agile_number_low_word = (CUShort(data(i + 3)) << 8) + CUShort(data(i + 2))
        agile_dash = (CUShort(data(i + 5)) << 8) + CUShort(data(i + 4))
        agile_rev_ascii = (CUShort(data(i + 7)) << 8) + CUShort(data(i + 6))

        i = i + 8 '8
        serial_number = (CUShort(data(i + 1)) << 8) + CUShort(data(i))
        firmware_branch = (CUShort(data(i + 3)) << 8) + CUShort(data(i + 2))
        firmware_major_rev = (CUShort(data(i + 5)) << 8) + CUShort(data(i + 4))
        firmware_minor_rev = (CUShort(data(i + 7)) << 8) + CUShort(data(i + 6))


    End Sub
End Class


Public Class ETM_ETHERNET_TX_DATA_STRUCTURE
    Public status_data As ETM_CAN_STATUS_REGISTER                ' This is 12 bytes of data
    Public debug_data As ETM_CAN_SYSTEM_DEBUG_DATA               ' This is 48 bytes of data
    Public can_status As ETM_CAN_CAN_STATUS                      ' This is 32 bytes of data
    Public configuration As ETM_CAN_AGILE_CONFIG                 ' This is 16 bytes of data

    Public custom_data() As UInt16                   ' This can be zero -> N bytes of Data
    Public custom_data_word_count As Byte

    Public data_identification As Byte         ' This is a unique identifier for each data set

    ' constructor
    Sub New(ByVal id As Byte, ByVal word_count As UInt16)
        status_data = New ETM_CAN_STATUS_REGISTER
        debug_data = New ETM_CAN_SYSTEM_DEBUG_DATA
        can_status = New ETM_CAN_CAN_STATUS
        configuration = New ETM_CAN_AGILE_CONFIG

        custom_data_word_count = word_count
        data_identification = id

        custom_data = New UInt16(word_count) {}

    End Sub

    Sub SetData(ByRef data() As Byte, ByVal length As UInt16, ByVal offset As Byte)
        Dim i As Byte
        ' check total length first
        If (length <> (custom_data_word_count * 2 + 108)) Then Exit Sub
        status_data.SetData(data, 12, offset)
        debug_data.SetData(data, 48, offset + 12)
        can_status.SetData(data, 32, offset + 60)
        configuration.SetData(data, 16, offset + 92)

        offset = offset + 108
        For i = 0 To (custom_data_word_count - 1)
            custom_data(i) = (CUShort(data(offset + i * 2 + 1)) << 8) + CUShort(data(offset + i * 2))
        Next

    End Sub

End Class




Public Class ETM_CAN_BOARD_DATA
    Public data_identification As Byte         ' This is a unique identifier for each data set

    ' Status Register
    Public control_notice_bits As UInt16
    Public fault_bits As UInt16
    Public logged_bits As UInt16
    Public not_logged_bits As UInt16

    'Log Data
    Public log_data(24) As UInt16

    ' Configuration 0
    Public agile_number As UInt32
    Public agile_dash As UInt16
    Public agile_rev_ascii As UInt16

    ' Configuarion 1
    Public serial_number As UInt16
    Public firmware_agile_rev As UInt16
    Public firmware_branch As UInt16
    Public firmware_branch_rev As UInt16

    'ECB Local Data 0
    Public ecb_local_data(16) As UInt16

    Sub New(ByVal id As Byte)
        data_identification = id
    End Sub

    Public Sub SetData(ByRef data As Byte(), ByVal length As UInt16, ByVal offset As Byte)
        If (length < 104) Then Exit Sub

        ' Status Register
        control_notice_bits = (CUShort(data(offset + 1)) << 8) + CUShort(data(offset))
        fault_bits = (CUShort(data(offset + 3)) << 8) + CUShort(data(offset + 2))
        logged_bits = (CUShort(data(offset + 5)) << 8) + CUShort(data(offset + 4))
        not_logged_bits = (CUShort(data(offset + 7)) << 8) + CUShort(data(offset + 6))

        'Log Data
        For i = 0 To (23)
            log_data(i) = (CUShort(data(offset + i * 2 + 1 + 8)) << 8) + CUShort(data(offset + i * 2 + 8))
        Next

        ' Configuration 0
        agile_rev_ascii = (CUShort(data(offset + 57)) << 8) + CUShort(data(offset + 56))
        agile_dash = (CUShort(data(offset + 59)) << 8) + CUShort(data(offset + 58))
        agile_number = (CUShort(data(offset + 63)) << 24) + (CUShort(data(offset + 62)) << 16) + (CUShort(data(offset + 61)) << 8) + CUShort(data(offset + 60))

        ' Configuration 1
        firmware_branch_rev = (CUShort(data(offset + 65)) << 8) + CUShort(data(offset + 64))
        firmware_branch = (CUShort(data(offset + 67)) << 8) + CUShort(data(offset + 66))
        firmware_agile_rev = (CUShort(data(offset + 69)) << 8) + CUShort(data(offset + 68))
        serial_number = (CUShort(data(offset + 71)) << 8) + CUShort(data(offset + 70))

        'local Data
        For i = 0 To (16)
            ecb_local_data(i) = (CUShort(data(offset + i * 2 + 1 + 72)) << 8) + CUShort(data(offset + i * 2 + 72))
        Next
    End Sub

End Class


Public Class ETM_CAN_DEBUG_DATA
    Public data_identification As Byte         ' This is a unique identifier for each data set

    Public debug_0 As UInt16
    Public debug_1 As UInt16
    Public debug_2 As UInt16
    Public debug_3 As UInt16

    Public debug_4 As UInt16
    Public debug_5 As UInt16
    Public debug_6 As UInt16
    Public debug_7 As UInt16

    Public debug_8 As UInt16
    Public debug_9 As UInt16
    Public debug_A As UInt16
    Public debug_B As UInt16

    Public debug_C As UInt16
    Public debug_D As UInt16
    Public debug_E As UInt16
    Public debug_F As UInt16


    Sub New(ByVal id As Byte)
        data_identification = id
    End Sub

    Public Sub SetData(ByRef data As Byte(), ByVal length As UInt16, ByVal offset As Byte)
        Dim i As Byte
        'If (length < 48) Then Exit Sub


        i = offset
        debug_0 = (CUShort(data(i + 1)) << 8) + CUShort(data(i))
        debug_1 = (CUShort(data(i + 3)) << 8) + CUShort(data(i + 2))
        debug_2 = (CUShort(data(i + 5)) << 8) + CUShort(data(i + 4))
        debug_3 = (CUShort(data(i + 7)) << 8) + CUShort(data(i + 6))

        i = offset + 8
        debug_4 = (CUShort(data(i + 1)) << 8) + CUShort(data(i))
        debug_5 = (CUShort(data(i + 3)) << 8) + CUShort(data(i + 2))
        debug_6 = (CUShort(data(i + 5)) << 8) + CUShort(data(i + 4))
        debug_7 = (CUShort(data(i + 7)) << 8) + CUShort(data(i + 6))

        i = offset + 16
        debug_8 = (CUShort(data(i + 1)) << 8) + CUShort(data(i))
        debug_9 = (CUShort(data(i + 3)) << 8) + CUShort(data(i + 2))
        debug_A = (CUShort(data(i + 5)) << 8) + CUShort(data(i + 4))
        debug_B = (CUShort(data(i + 7)) << 8) + CUShort(data(i + 6))

        i = offset + 24
        debug_C = (CUShort(data(i + 1)) << 8) + CUShort(data(i))
        debug_D = (CUShort(data(i + 3)) << 8) + CUShort(data(i + 2))
        debug_E = (CUShort(data(i + 5)) << 8) + CUShort(data(i + 4))
        debug_F = (CUShort(data(i + 7)) << 8) + CUShort(data(i + 6))


    End Sub

End Class




Public Structure ETM_ETHERNET_CAL_STRUCTURE
    Public scale As UInt16
    Public offset As UInt16
    ' constructor

End Structure
Public Class ETM_ETHERNET_COMMAND_STRUCTURE
    Public command_index As UInt16
    Public data(3) As UInt16

    ' constructor
    Sub New(ByVal index As UInt16, ByVal word2 As UInt16, ByVal word1 As UInt16, ByVal word0 As UInt16)
        command_index = index
        data(0) = word0
        data(1) = word1
        data(2) = word2
    End Sub
End Class

